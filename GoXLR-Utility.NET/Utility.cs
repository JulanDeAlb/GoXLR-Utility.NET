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
        private static MessageHandler _messageHandler;
        private long _id;
        private static WebSocket _websocket;
        private static JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        public Status Status = new Status();
        public CancellationTokenSource TokenSource;
        public Events.Events Events = new Events.Events();
        public List<string> AvailableSerialNumbers => MessageHandler.AvailableSerialNumbers;
        
        public Utility(CancellationTokenSource cToken = null)
        {
            _websocket = new WebSocket("ws://localhost:14564/api/websocket");
            _messageHandler = new MessageHandler(Events, Status, _serializerOptions);
            
            TokenSource = cToken ?? new CancellationTokenSource();
            
            _websocket.OnOpen += OnWsConnected;
            _websocket.OnMessage += OnWsMessage;
            _websocket.OnClose += OnWsDisconnected;
            _websocket.OnError += OnWsError;
        }

        public void Connect()
        {
            Interlocked.Exchange(ref _id, 0);
            _websocket.Connect();
        }

        public void Disconnect()
        {
            _websocket.Close();
        }

        public void Send(string message)
        {
            _websocket.Send(message);
        }

        private static void OnWsConnected(object sender, System.EventArgs eventArgs)
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