using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
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

        public Utility(CancellationTokenSource cToken = null)
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
    }
}