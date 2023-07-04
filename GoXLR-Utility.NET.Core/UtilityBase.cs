using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using GoXLR_Utility.NET.Commands;
using GoXLR_Utility.NET.Core.Extensions;
using GoXLR_Utility.NET.Enums.Commands;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Core
{
    public abstract class UtilityBase
    {
        private static uint _id;
        private static UnixOrPipeClient _unixOrPipeClient;
        private static WebSockets _websocket;

        public static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        public static ILogger Logger;

        public bool IsConnected;

        /// <summary>
        /// Event that gets fired when it successfully connected.
        /// </summary>
        public event EventHandler<string> OnConnected;
        
        /// <summary>
        /// Event that gets fired when an error occured.
        /// </summary>
        public event EventHandler<ErrorEventArgs> OnError;
        
        /// <summary>
        /// Event that gets fired when it successfully disconnected.
        /// </summary>
        public event EventHandler<string> OnDisconnected;

        /// <summary>
        /// Initialize a new Utility Client.
        /// </summary>
        public UtilityBase(ILogger logger = null)
        {
            Logger = logger;
            _unixOrPipeClient = new UnixOrPipeClient();
        }

        #region WebSocket
        
        #region Connection

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

            _id = 0;
            IsConnected = _websocket.ConnectAsync().GetAwaiter().GetResult();
            return IsConnected;
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket while using the
        /// Windows Named Pipe to get the WebSocket URL.
        /// </summary>
        /// <returns>True on success</returns>
        public async Task<bool> ConnectAsync()
        {
            var settings = _unixOrPipeClient?.Connect();
            
            if (settings == null || !settings.Enabled)
                return false;
            
            InitializeWebSocket(settings.ToWebSocketString());
            
            _id = 0;
            IsConnected = await _websocket.ConnectAsync();
            return IsConnected;
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket.
        /// </summary>
        /// <param name="url">The URL to connect to</param>
        /// <returns>True on success</returns>
        public bool Connect(string url)
        {
            InitializeWebSocket(url);

            _id = 0;
            IsConnected = _websocket.ConnectAsync().GetAwaiter().GetResult();
            return IsConnected;
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket.
        /// </summary>
        /// <param name="url">The URL to connect to</param>
        /// <returns>True on success</returns>
        public async Task<bool> ConnectAsync(string url)
        {
            InitializeWebSocket(url);
            
            _id = 0;
            IsConnected = await _websocket.ConnectAsync();
            return IsConnected;
        }

        /// <summary>
        /// Disconnect from the GoXLR Daemon WebSocket
        /// </summary>
        public void Disconnect()
        {
            _websocket.DisconnectAsync();
            IsConnected = false;
        }

        #endregion

        /// <summary>
        /// Initialize the WebSocket
        /// </summary>
        /// <param name="url">URL to connect to</param>
        private void InitializeWebSocket(string url)
        {
            _websocket = new WebSockets();
            _websocket.Initialize(url);
            
            _websocket.OnConnected += OnWsConnected;
            _websocket.OnMessage += OnWsMessage;
            _websocket.OnDisconnected += OnWsDisconnected;
            _websocket.OnError += OnWsError;
        }

        /// <summary>
        /// WebSocket OnConnected Event
        /// </summary>
        private void OnWsConnected(object sender, string message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Connected to Utility.");
            OnConnected?.Invoke(this, message);
            SendCommand(SimpleCommand.GetStatus);
        }

        /// <summary>
        /// WebSocket OnMessage Event
        /// </summary>
        protected abstract void OnWsMessage(object sender, string message);

        /// <summary>
        /// WebSocket OnDisconnected Event
        /// </summary>
        private void OnWsDisconnected(object sender, string message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Disconnected from Utility.");
            OnDisconnected?.Invoke(this, message);
        }

        /// <summary>
        /// WebSocket OnError Event
        /// </summary>
        private void OnWsError(object sender, ErrorEventArgs data)
        {
            Logger?.Log(LogLevel.Error, new EventId(1, "Daemon connectivity"), data.Exception, "Error occured on the Websocket.");
            OnError?.Invoke(sender, data);
        }

        #endregion

        #region Commands

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="deviceCommand">The Command that should be send.</param>
        public async ValueTask<bool> SendCommandAsync(string serialNumber, DeviceCommandBase deviceCommand)
        {
            LogCommand(deviceCommand);
            var commands = deviceCommand.GetJson(ref _id, serialNumber);
            
            if (commands is null)
                return false;

            var allValid = true;
            foreach (var cmd in commands)
            {
                var result = await SendAsync(_id, cmd, serialNumber);
                
                if (!result)
                    allValid = false;
            }

            return allValid;
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="deviceCommand">The Command that should be send.</param>
        public void SendCommand(string serialNumber, DeviceCommandBase deviceCommand)
        {
            SendCommandAsync(serialNumber, deviceCommand).StepOver(exception => throw exception);
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="normalCommand">The Command that should be send.</param>
        public async ValueTask<bool> SendCommandAsync(NormalCommandBase normalCommand)
        {
            LogCommand(normalCommand);
            var commands = normalCommand.GetJson(ref _id);

            if (commands is null)
                return false;

            var allValid = true;
            foreach (var cmd in commands)
            {
                var result = await SendAsync(_id, cmd);
                
                if (!result)
                    allValid = false;
            }

            return allValid;
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="normalCommand">The Command that should be send.</param>
        public void SendCommand(NormalCommandBase normalCommand)
        {
            SendCommandAsync(normalCommand).StepOver(exception => throw exception);
        }

        /// <summary>
        /// Send the GoXLR Daemon a Command to open a Path in File Explorer
        /// </summary>
        /// <param name="path">The Path which should be opened</param>
        public async ValueTask<bool> OpenPathAsync(PathEnum path)
        {
            var command = new CommandBase { Path = path.ToString() }.GetJson(ref _id);
            if (command == null)
                return false;

            return await SendAsync(_id, command[0]);
        }

        /// <summary>
        /// Send the GoXLR Daemon a Command to open a Path in File Explorer
        /// </summary>
        /// <param name="path">The Path which should be opened</param>
        public void OpenPath(PathEnum path)
        {
            OpenPathAsync(path).StepOver(exception => throw exception);
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon which doesnt require a Device/SerialNumber.
        /// </summary>
        /// <param name="command">The Command to send</param>
        public async ValueTask<bool> SendCommandAsync(SimpleCommand command)
        {
            var sendCommand = new DeviceCommandBase { Object = command.ToString() }.GetJson(ref _id);
            if (sendCommand == null)
                return false;

            return await SendAsync(_id, sendCommand[0]);
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon which doesnt require a Device/SerialNumber.
        /// </summary>
        /// <param name="command">The Command to send</param>
        public void SendCommand(SimpleCommand command)
        {
            SendCommandAsync(command).StepOver(exception => throw exception);
        }

        /// <summary>
        /// Send a Simple Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
        /// </summary>
        /// <param name="commandName">As String<br/>(Example: SetTTSEnabled)</param>
        /// <param name="parameters">The Parameters<br/>(Example: true)</param>
        public async ValueTask<bool> SendCustomCommandAsync(string commandName, params object[] parameters)
        {
            if (parameters.Length < 1)
                return false;

            var commandParameters = parameters.Length == 1
                ? parameters[0]
                : parameters;

            return await SendCommandAsync(new Dictionary<string, object>
            {
                [commandName] = commandParameters
            });
        }

        /// <summary>
        /// Send a Simple Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
        /// </summary>
        /// <param name="commandName">As String<br/>(Example: SetTTSEnabled)</param>
        /// <param name="parameters">The Parameters<br/>(Example: true)</param>
        public void SendCustomCommand(string commandName, params object[] parameters)
        {
            SendCustomCommandAsync(commandName, parameters).StepOver(exception => throw exception);
        }

        /// <summary>
        /// Send a Device Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="commandName">As String<br/>(Example: SetVolume)</param>
        /// <param name="parameters">The Parameters<br/>(Example: "Game", 255)</param>
        public async ValueTask<bool> SendCustomCommandAsync(string serialNumber, string commandName, params object[] parameters)
        {
            if (parameters.Length < 1)
                return false;

            var commandParameters = parameters.Length == 1
                ? parameters[0]
                : parameters;

            return await SendCommandAsync(new Dictionary<string, object>
            {
                [commandName] = commandParameters
            }, serialNumber);
        }

        /// <summary>
        /// Send a Device Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
        /// </summary>
        /// <param name="serialNumber">SerialNumber on which the Command should be applied.</param>
        /// <param name="commandName">As String<br/>(Example: SetVolume)</param>
        /// <param name="parameters">The Parameters<br/>(Example: "Game", 255)</param>
        public void SendCustomCommand(string serialNumber, string commandName, params object[] parameters)
        {
            SendCustomCommandAsync(serialNumber, commandName, parameters).StepOver(exception => throw exception);
        }
        
        /// <summary>
        /// Log command info if necessary.
        /// </summary>
        /// <param name="command">The Command</param>
        private void LogCommand(CommandBase command)
        {
            if (command.LogInfo is null)
                return;
            
            if (command.LogInfo.IsMinimum)
                Logger?.Log(command.LogInfo.LogLevel, command.LogInfo.EventId, "{cmdName} exceeds min. Value: {minValue}", command.LogInfo.CmdName, command.LogInfo.Value);
            else
                Logger?.Log(command.LogInfo.LogLevel, command.LogInfo.EventId, "{cmdName} exceeds max. Value: {maxValue}", command.LogInfo.CmdName, command.LogInfo.Value);
        }
        
        /// <summary>
        /// Send the Message via WebSocket
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="message">Message</param>
        /// <param name="serialNumber">Message</param>
        private async Task<bool> SendAsync(long id, string message, string serialNumber = null)
        {
            var debugMessage = serialNumber != null ? message.Replace(serialNumber, "SerialNumber") : message;

            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message got send to Utility: {message}", debugMessage);
            return await _websocket.SendAsync(id, message);
        }
		
        /// <summary>
        /// Base Class of <see cref="SendCustomCommandAsync(string,string,object[])"/>
        /// </summary>
        /// <param name="command">Command as Object</param>
        /// <param name="serialNumber">SerialNumber</param>
        private async Task<bool> SendCommandAsync(object command, string serialNumber = null)
        {
            IncrementId();

            object finalRequest;
            if (serialNumber != null)
                finalRequest = new
                {
                    id = _id,
                    data = new
                    {
                        Command = new[]
                        {
                            serialNumber,
                            command
                        }
                    }
                };
            else
                finalRequest = new
                {
                    id = _id,
                    data = command
                };

            var message = JsonSerializer.Serialize(finalRequest, SerializerOptions);
            var debugMessage = serialNumber != null ? message.Replace(serialNumber, "SerialNumber") : message;

            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message got send to Utility: {message}", debugMessage);
            return await _websocket.SendAsync(_id, message);
        }

        #endregion
        
        /// <summary>
        /// Increment the ID
        /// </summary>
        private void IncrementId()
        {
            if (_id == uint.MaxValue)
                _id = 0;
            else
                _id++;
        }
    }
}