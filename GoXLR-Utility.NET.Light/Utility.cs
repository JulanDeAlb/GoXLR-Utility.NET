using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading;
using GoXLR_Utility.NET.Commands;
using GoXLR_Utility.NET.Enums.Commands;
using GoXLR_Utility.NET.Enums.Response;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using GoXLR_Utility.NET.Light.Models;
using Microsoft.Extensions.Logging;
using WebSocketSharp;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace GoXLR_Utility.NET.Light
{
    public class Utility
    {
        private static long _id;
        private static UnixOrPipeClient _unixOrPipeClient;
        private static WebSocket _websocket;
        
        internal static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        internal static ILogger Logger;

        public event EventHandler<Patch> OnPatch;

        /// <summary>
        /// A List of available SerialNumbers
        /// </summary>
        public List<string> AvailableSerialNumbers { get; private set; }

        /// <summary>
        /// Initialize a new Utility Client.
        /// </summary>
        public Utility(ILogger logger = null)
        {
            Logger = logger;
            AvailableSerialNumbers = new List<string>();
            _unixOrPipeClient = new UnixOrPipeClient();
        }

        /// <summary>
        /// Connect to the GoXLR Daemon via WebSocket while using the
        /// Windows Named Pipe to get the WebSocket URL.
        /// </summary>
        /// <returns>True on success</returns>
        //public bool Connect()
        //{
        //    var settings = _unixOrPipeClient?.Connect();
        //    
        //    if (settings == null || !settings.Enabled)
        //        return false;
        //    
        //    InitializeWebSocket(settings.ToWebSocketString());
        //    
        //    Interlocked.Exchange(ref _id, 0);
        //    _websocket?.Connect();
        //    return true;
        //}

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
            LogCommand(deviceCommand);
            var commands = deviceCommand.GetJson(_id, serialNumber);
            
            if (commands is null)
                return;

            foreach (var cmd in commands)
            {
                Send(cmd, serialNumber);
            }
        }

        /// <summary>
        /// Send a Command to the GoXLR Daemon.
        /// </summary>
        /// <param name="normalCommand">The Command that should be send.</param>
        public void SendCommand(NormalCommandBase normalCommand)
        {
            IncrementId();
            LogCommand(normalCommand);
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
        /// Send a Simple Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
        /// </summary>
        /// <param name="commandName">As String<br/>(Example: SetTTSEnabled)</param>
        /// <param name="parameters">The Parameters<br/>(Example: true)</param>
        public void SendCommand(string commandName, params object[] parameters)
        {
            if (parameters.Length < 1)
                return;

            var commandParameters = parameters.Length == 1
                ? parameters[0]
                : parameters;

            SendCommand(new Dictionary<string, object>
            {
                [commandName] = commandParameters
            });
        }

        /// <summary>
        /// Send a Device Command using its Command String and the Parameters
        /// in case the Command isn't implemented or not working.<br/>
        /// All Commands can be found <a href="https://github.com/GoXLR-on-Linux/goxlr-utility/blob/main/ipc/src/lib.rs">HERE</a>.
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

            SendCommand(new Dictionary<string, object>
            {
                [commandName] = commandParameters
            }, serialNumber);
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
                Logger.Log(command.LogInfo.LogLevel, command.LogInfo.EventId, "{cmdName} exceeds min. Value: {minValue}", command.LogInfo.CmdName, command.LogInfo.Value);
            else
                Logger.Log(command.LogInfo.LogLevel, command.LogInfo.EventId, "{cmdName} exceeds max. Value: {maxValue}", command.LogInfo.CmdName, command.LogInfo.Value);
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
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message from Utility received: {message}", message.Data);

            try
            {
                var json = JsonSerializer.Deserialize<JsonObject>(message.Data);

                if (!json.TryGetPropertyValue("data", out var data) || data is null)
                    return;

                if (data.ToJsonString().Equals("\"Ok\"", StringComparison.OrdinalIgnoreCase))
                    return;
                
                if (data.AsObject().TryGetPropertyValue("Status", out var status) && status != null)
                {
                    var mixer = status["mixers"];
                    if (mixer != null)
                    {
                        AvailableSerialNumbers = mixer.AsObject().Select(pair => pair.Key).ToList();
                    }

                    TraverseObject(status, "");
                }

                if (!data.AsObject().TryGetPropertyValue("Patch", out var patches) && patches is null)
                    return;

                var patchArray = patches?.AsArray();
                if (patchArray is null)
                    return;
                
                foreach (var patch in patchArray.Deserialize<Patch[]>(SerializerOptions))
                {
                    var pathSplit = patch.Path.Split('/');
                    if (pathSplit.Length == 3 && pathSplit[1].Equals("mixers"))
                    {
                        if (patch.Value is null && AvailableSerialNumbers.Contains(pathSplit[2]))
                        {
                            AvailableSerialNumbers.Remove(pathSplit[2]);
                        }
                        else if (patch.Value != null && !AvailableSerialNumbers.Contains(pathSplit[2]))
                        {
                            AvailableSerialNumbers.Add(pathSplit[2]);
                            TraverseObject(patch.Value, $"/mixers/{pathSplit[2]}");
                            return;
                        }
                    }
                    
                    OnPatch?.Invoke(this, patch);
                }
            }
            catch (Exception e)
            {
                Logger?.Log(LogLevel.Error, new EventId(0, "Please Report"), $"Unexpected error within handling messages: {e.StackTrace}");
            }
        }

        /// <summary>
        /// Traverse trough every object within the Status to manually
        /// send Patches for it.
        /// </summary>
        /// <param name="jObject">The object to traverse trough</param>
        /// <param name="prefix">Optional Path Prefix</param>
        private void TraverseObject(JsonNode jObject, string prefix)
        {
            foreach (var property in jObject.AsObject())
            {
                switch (property.Value)
                {
                    case JsonObject jObj:
                        TraverseObject(jObj, prefix);
                        break;
                    
                    case JsonArray jArray:
                        foreach (var item in jArray)
                        {
                            switch (item)
                            {
                                case JsonObject jObj:
                                    TraverseObject(jObj, prefix);
                                    break;
                                
                                default:
                                    OnPatch?.Invoke(this, new Patch { Op = OpPatchEnum.Replace, Path = prefix + ConvertPath(item.GetPath()), Value = item.ToString()});
                                    break;
                            }
                        }
                        break;
                    
                    default:
                        var value = property.Value?.AsValue();
                        if (value != null)
                            OnPatch?.Invoke(this, new Patch { Op = OpPatchEnum.Replace, Path = prefix + ConvertPath(property.Value?.GetPath()), Value = property.Value?.AsValue()});
                        break;
                }
            }
        }

        /// <summary>
        /// Convert the System.Text.Json Path to the Utility Path
        /// </summary>
        /// <param name="path">Path to convert</param>
        /// <returns></returns>
        private static string ConvertPath(string path)
        {
            if (path is null)
                return string.Empty;
            
            path = path.Replace("$.data.Status", "");
            
            var startIndex = path.IndexOf("['", StringComparison.Ordinal);
            var endIndex = path.LastIndexOf("']", StringComparison.Ordinal);
            if (startIndex != -1 && endIndex != -1)
            {
                var prefix = path.Substring(0, startIndex).Replace(".", "/");
                var suffix = path.Substring(endIndex).Replace(".", "/");
                var substring = path.Substring(startIndex, endIndex - startIndex);
                path = prefix + substring + suffix;
            }
            else
            {
                path = path.Replace(".", "/");
            }

            return path;
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
        /// <param name="serialNumber">Message</param>
        private void Send(string message, string serialNumber = null)
        {
            var debugMessage = serialNumber != null ? message.Replace(serialNumber, "SerialNumber") : message;

            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message got send to Utility: {message}", debugMessage);
            _websocket?.Send(message);
        }
		
        /// <summary>
        /// Base Class of <see cref="SendCommand(string, string, object[])"/>
        /// </summary>
        /// <param name="command">Command as Object</param>
        /// <param name="serialNumber">SerialNumber</param>
        private void SendCommand(object command, string serialNumber = null)
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
            _websocket?.Send(message);
        }
    }
}