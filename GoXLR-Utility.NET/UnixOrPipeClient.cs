using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.HttpSettings;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET
{
    public class UnixOrPipeClient
    {
        private readonly JsonSerializerOptions? _jsonSerializerOptions;

        public UnixOrPipeClient(JsonSerializerOptions? jsonSerializerOptions)
        {
            _jsonSerializerOptions = jsonSerializerOptions;
        }

        public HttpSettings? Connect()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ConnectPipe() : ConnectUnix();
        }

        private HttpSettings? ConnectUnix()
        {
            Utility.Logger?.Log(LogLevel.Information, new EventId(0, "Please Report"), "I dont know if {methode} works", nameof(ConnectUnix));
            var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);

            try
            {
                socket.Connect(new UnixDomainSocketEndPoint("/tmp/goxlr.socket"));
            }
            catch
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), "Unable to connect to the GoXLR Pipe using Unix.");
                return null;
            }

            var networkStream = new NetworkStream(socket);
            var reader = new BinaryReader(networkStream);
            var writer = new BinaryWriter(networkStream);

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

            socket.Close();
            networkStream.Close();

            return JsonSerializer.Deserialize<DataPayload>(new string(responseBody), _jsonSerializerOptions)?.HttpState;
        }
        
        private HttpSettings? ConnectPipe()
        {
            var processes = Process.GetProcessesByName("goxlr-daemon");
            if (processes.Length == 0)
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), "GoXLR Utility Daemon not Running.");
                return null;
            }

            var client = new NamedPipeClientStream("@goxlr.socket");

            try
            {
                client.Connect(20);
            }
            catch
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), "Unable to connect to the GoXLR Pipe using Pipe.");
                return null;
            }

            var reader = new BinaryReader(client);
            var writer = new BinaryWriter(client);

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

            client.Close();

            return JsonSerializer.Deserialize<DataPayload>(new string(responseBody), _jsonSerializerOptions)?.HttpState;
        }
    }
}