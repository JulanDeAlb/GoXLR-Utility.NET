using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using GoXLR_Utility.NET.Light.Models;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Light
{
    public class UnixOrPipeClient
    {
        public HttpSettings Connect()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ConnectPipe() : ConnectUnix();
        }

        private HttpSettings ConnectUnix()
        {
            Utility.Logger?.Log(LogLevel.Information, new EventId(0, "Please Report"), "I dont know if {methode} works", nameof(ConnectUnix));
            var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);

            try
            {
#if NETSTANDARD2_0
                throw new NotSupportedException(".NET Standard 2.0 does not support UnixDomainSocketEndPoint");
#else
                socket.Connect(new UnixDomainSocketEndPoint("/tmp/goxlr.socket"));
#endif
            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(NotSupportedException))
                    throw;

                Utility.Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), e, "Unable to connect to the GoXLR Pipe using Unix.");
                return null;
            }

            var networkStream = new NetworkStream(socket);
            var reader = new BinaryReader(networkStream);
            var writer = new BinaryWriter(networkStream);

            var bytes = Encoding.ASCII.GetBytes("\"GetStatus\"");
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
            var responseBytes = reader.ReadBytes((int)responseLength);
            var response = Encoding.UTF8.GetString(responseBytes);

            socket.Close();
            networkStream.Close();

            return JsonSerializer.Deserialize<ShortResponse>(response, Utility.SerializerOptions)?.Status.Config.HttpSettings;
        }
        
        private HttpSettings ConnectPipe()
        {
            var processes = Process.GetProcessesByName("goxlr-daemon");
            if (processes.Length == 0)
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), "GoXLR Utility Daemon probably not Running.");
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

            var bytes = Encoding.ASCII.GetBytes("\"GetStatus\"");
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
            var responseBytes = reader.ReadBytes((int)responseLength);
            var response = Encoding.UTF8.GetString(responseBytes);

            client.Close();
            return JsonSerializer.Deserialize<ShortResponse>(response, Utility.SerializerOptions)?.Status.Config.HttpSettings;
        }
    }
}