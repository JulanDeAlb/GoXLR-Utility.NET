using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using GoXLR_Utility.NET.Commands;
using GoXLR_Utility.NET.Enums.Commands;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using GoXLR_Utility.NET.Models.Response.HttpSettings;
using GoXLR_Utility.NET.Models.Response.Status;
using GoXLR_Utility.NET.Models.Response.Status.Config;
using GoXLR_Utility.NET.Models.Response.Status.Files;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;
using GoXLR_Utility.NET.Models.Response.Status.Paths;
using Microsoft.Extensions.Logging;
using WebSocketSharp;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace GoXLR_Utility.NET
{
    public class Utility
    {
        private readonly MessageHandler _messageHandler;

        private static long _id;
        private static UnixOrPipeClient _unixOrPipeClient;
        private static WebSocket _websocket;
        
        internal static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        internal static ILogger Logger;

        /// <summary>
        /// The Daemon Status including:
        /// <br/><see cref="Config"/>,
        /// <br/><see cref="Files"/>,
        /// <br/><see cref="Device"/> as Dictionary using SerialNumber,
        /// <br/><see cref="Paths"/>
        /// </summary>
        public Status Status => _messageHandler.Status;

        /// <summary>
        /// The Daemon HttpSettings
        /// </summary>
        public HttpSettings HttpSettings => _messageHandler.HttpSettings;
        
        /// <summary>
        /// A List of available SerialNumbers
        /// </summary>
        public List<string> AvailableSerialNumbers => Status.Mixers.Keys.ToList();

        /// <summary>
        /// Initialize a new Utility Client.
        /// </summary>
        public Utility(ILogger logger = null)
        {
            Logger = logger;
            _messageHandler = new MessageHandler();
            _unixOrPipeClient = new UnixOrPipeClient();
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket while using the
        /// Windows Named Pipe to get the WebSocket URL.
        /// </summary>
        /// <returns>True on success</returns>
        public bool Connect()
        {
            var settings = _unixOrPipeClient?.Connect();
            
            if (settings == null || !settings.Enabled)
                return false;
            
            InitializeWebSocket(settings.ToWebSocketString());
            
            Interlocked.Exchange(ref _id, 0);
            _websocket?.Connect();
            return true;
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket.
        /// </summary>
        /// <param name="url">The URL to connect to</param>
        /// <returns>True on success</returns>
        public bool Connect(string url)
        {
            InitializeWebSocket(url);
            
            Interlocked.Exchange(ref _id, 0);
            _websocket?.Connect();
            return true;
        }

        /// <summary>
        /// Disconnect from the GoXLR Daemon WebSocket
        /// </summary>
        public void Disconnect()
        {
            _websocket?.Close();
        }
        
        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="deviceCommand">The Command that should be send.</param>
        public void SendCommand(string serialNumber, DeviceCommandBase deviceCommand)
        {
            IncrementId();
            var commands = deviceCommand.GetJson(_id, serialNumber);

            if (commands is null)
                return;

            foreach (var cmd in commands)
            {
                Send(cmd);
            }
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="normalCommand">The Command that should be send.</param>
        public void SendCommand(NormalCommandBase normalCommand)
        {
            IncrementId();
            var commands = normalCommand.GetJson(_id);

            if (commands is null)
                return;

            foreach (var cmd in commands)
            {
                Send(cmd);
            }
        }

        /// <summary>
        /// Send the GoXLR Daemon a Command to open a Path in File Explorer
        /// </summary>
        /// <param name="path">The Path which should be opened</param>
        public void OpenPath(PathEnum path)
        {
            IncrementId();

            var command = new CommandBase { Path = path.ToString() }.GetJson(_id);
            if (command == null)
                return;

            Send(command[0]);
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon which doesnt require a Device/SerialNumber.
        /// </summary>
        /// <param name="command">The Command to send</param>
        public void SendSimpleCommand(SimpleCommand command)
        {
            IncrementId();

            var sendCommand = new DeviceCommandBase { Object = command.ToString() }.GetJson(_id);
            if (sendCommand == null)
                return;

            Send(sendCommand[0]);
        }
        
        /// <summary>
        /// Send a Device Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="commandName">As String<br/>(Example: SetVolume)</param>
        /// <param name="parameters">The Parameters<br/>(Example: "Game", 255)</param>
        public void SendCommand(string serialNumber, string commandName, params object[] parameters)
        {
            if (parameters.Length < 1)
                return;

            var commandParameters = parameters.Length == 1
                ? parameters[0]
                : parameters;

            SendCommand(serialNumber, new Dictionary<string, object>
            {
                [commandName] = commandParameters
            });
        }
        
        /// <summary>
        /// Initialize the WebSocket
        /// </summary>
        /// <param name="url">URL to connect to</param>
        private void InitializeWebSocket(string url)
        {
            _websocket = new WebSocket(url);
            
            _websocket.OnOpen += OnWsConnected;
            _websocket.OnMessage += OnWsMessage;
            _websocket.OnClose += OnWsDisconnected;
            _websocket.OnError += OnWsError;
        }

        /// <summary>
        /// WebSocket OnConnected Event
        /// </summary>
        private void OnWsConnected(object sender, EventArgs eventArgs)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Connected to Utility.");
            SendSimpleCommand(SimpleCommand.GetStatus);
        }
        
        /// <summary>
        /// WebSocket OnMessage Event
        /// </summary>
        private void OnWsMessage(object sender, MessageEventArgs message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message from Utility received.");
            _messageHandler.HandleMessage(message.Data);
        }

        /// <summary>
        /// WebSocket OnDisconnected Event
        /// </summary>
        private static void OnWsDisconnected(object sender, CloseEventArgs closeEventArgs)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Disconnected from Utility.");
        }

        /// <summary>
        /// WebSocket OnError Event
        /// </summary>
        private static void OnWsError(object sender, ErrorEventArgs e)
        {
            Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), e.Exception, "Error occured on the Websocket.");
        }
        
        /// <summary>
        /// Increment the ID
        /// </summary>
        private void IncrementId()
        {
            if (_id == long.MaxValue)
                Interlocked.Exchange(ref _id, 0);
            else 
                Interlocked.Increment(ref _id);
        }
        
        /// <summary>
        /// Send the Message via WebSocket
        /// </summary>
        /// <param name="message">Message</param>
        private void Send(string message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message got send to Utility: {message}", message);
            _websocket?.Send(message);
        }
		
        /// <summary>
        /// Base Class of <see cref="SendCommand(string, string, object[])"/>
        /// </summary>
        /// <param name="serialNumber">SerialNumber</param>
        /// <param name="command">Command as Object</param>
        private void SendCommand(string serialNumber, object command)
        {
            IncrementId();
            var finalRequest = new
            {
                _id,
                data = new
                {
                    Command = new[] {
                        serialNumber,
                        command
                    }
                }
            };
			
            var json = JsonSerializer.Serialize(finalRequest, SerializerOptions);
            _websocket?.Send(json);
        }
    }
}