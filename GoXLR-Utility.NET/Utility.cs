using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using GoXLR_Utility.NET.Commands;
using GoXLR_Utility.NET.Enums.Commands;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using GoXLR_Utility.NET.Models.Response.Status;
using WebSocketSharp;
using ErrorEventArgs = WebSocketSharp.ErrorEventArgs;

namespace GoXLR_Utility.NET
{
    public class Utility
    {
        private static NamedPipeServer _namedPipeServer;
        private static MessageHandler _messageHandler;
        private static long _id;
        private static WebSocket _websocket;
        private static JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        public readonly Status Status = new Status();
        public readonly Events.Events Events = new Events.Events();
        public List<string> AvailableSerialNumbers => MessageHandler.AvailableSerialNumbers;
        
        public bool ShouldInvokeEvents
        {
            get => _messageHandler.ShouldInvokeEvents;
            set => _messageHandler.ShouldInvokeEvents = value;
        }

        public Utility()
        {
            _messageHandler = new MessageHandler(Events, Status, _serializerOptions);
            _namedPipeServer = new NamedPipeServer(_serializerOptions);
        }

        public bool Connect()
        {
            var settings = _namedPipeServer.Connect();
            
            if (settings == null || !settings.Enabled)
                return false;

            InitializeWebSocket(settings.ToWebSocketString());
            
            Interlocked.Exchange(ref _id, 0);
            _websocket.Connect();
            return true;
        }

        public void Disconnect()
        {
            _websocket.Close();
        }
        
        public void SendCommand(string serialNumber, CommandBase command)
        {
            Interlocked.Increment(ref _id);
            Send(command.GetJson(_id, serialNumber));
        }

        public void OpenPath(PathEnum path)
        {
            Interlocked.Increment(ref _id);
            Send(new CommandBase{ Path = path }.GetJson(_id));
        }

        public void SendSimpleCommand(SimpleCommandEnum command)
        {
            Interlocked.Increment(ref _id);
            Send(new CommandBase{ Object = command }.GetJson(_id));
        }

        public void Send(string message)
        {
            _websocket.Send(message);
        }

        private void InitializeWebSocket(string url)
        {
            _websocket = new WebSocket(url);
            
            _websocket.OnOpen += OnWsConnected;
            _websocket.OnMessage += OnWsMessage;
            _websocket.OnClose += OnWsDisconnected;
            _websocket.OnError += OnWsError;
        }

        private void OnWsConnected(object sender, System.EventArgs eventArgs)
        {
            Console.WriteLine("Connected");
            
            //TODO Send GetStatus Command
            _websocket.Send("{\"id\":0, \"data\":\"GetStatus\"}");
        }

        private static void OnWsMessage(object sender, MessageEventArgs message)
        {
            _messageHandler.HandleMessage(message.Data);
        }

        private static void OnWsDisconnected(object sender, CloseEventArgs closeEventArgs)
        {
            Console.WriteLine("Disconnected");
        }

        private static void OnWsError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Exception);
        }

        public void SendCommand(string serialNumber, string commandName, params object[] parameters)
        {
            if (commandName is null)
                return;

            if (parameters is null || parameters.Length < 1)
                return;

            var commandParameters = parameters.Length == 1
                ? parameters[0]
                : parameters;

            SendCommand(serialNumber, new Dictionary<string, object>
            {
                [commandName] = commandParameters
            });
        }
		
        private void SendCommand(string serialNumber, object command)
        {
            if (serialNumber is null)
                return;

            var id = _id++;
            var finalRequest = new
            {
                id,
                data = new
                {
                    Command = new[] {
                        serialNumber,
                        command
                    }
                }
            };
			
            var json = JsonSerializer.Serialize(finalRequest, _serializerOptions);
            _websocket.Send(json);
        }
    }
}