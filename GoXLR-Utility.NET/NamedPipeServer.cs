using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Text.Json;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.HttpSettings;

namespace GoXLR_Utility.NET
{
    public class NamedPipeServer
    {
        private NamedPipeClientStream _client;
        private JsonSerializerOptions _jsonSerializerOptions;
        private readonly string _url = "@goxlr.socket";

        public NamedPipeServer(JsonSerializerOptions jsonSerializerOptions)
        {
            _jsonSerializerOptions = jsonSerializerOptions;
        }
        
        public HttpSettings Connect()
        {
            var processes = Process.GetProcessesByName("goxlr-daemon");
            if (processes.Length == 0)
            {
                Console.Error.WriteLine("GoXLR Utility Daemon not Running");
                return null;
            }

            _client = new NamedPipeClientStream(_url);

            try
            {
                _client.Connect(20);
            }
            catch
            {
                Console.Error.WriteLine("Unable to connect to the GoXLR Pipe");
                return null;
            }
            
            var reader = new BinaryReader(_client);
            var writer = new BinaryWriter(_client);

            var bytes = Encoding.ASCII.GetBytes("\"GetHttpState\"");
            var len = BitConverter.GetBytes(bytes.Length);
            
            //LittleEndian check and change
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(len);
            }
            
            //First write the length and then the bytes
            writer.Write(len);
            writer.Write(bytes);

            var responseLengthBytes = reader.ReadBytes(4);

            // Again, LittleEndian check and change
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(responseLengthBytes);
            }
            
            var responseLength = BitConverter.ToUInt32(responseLengthBytes, 0);
            var responseBody = reader.ReadChars((int) responseLength);
            return JsonSerializer.Deserialize<DataPayload>(new string(responseBody), _jsonSerializerOptions).HttpState;
        }
    }
}