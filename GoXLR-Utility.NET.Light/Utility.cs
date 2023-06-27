using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using GoXLR_Utility.NET.Core;
using GoXLR_Utility.NET.Core.Models;
using GoXLR_Utility.NET.Enums.Response;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Light
{
    public class Utility : UtilityBase
    {
        /// <summary>
        /// Event that gets fired when a patch occured.
        /// </summary>
        public event EventHandler<Patch> OnPatch;
        
        /// <summary>
        /// An Observable Collection of available SerialNumbers
        /// </summary>
        public ObservableCollection<string> AvailableSerialNumbers { get; private set; }

        /// <inheritdoc />
        public Utility(ILogger logger = null) : base(logger)
        {
            AvailableSerialNumbers = new ObservableCollection<string>();
        }
        
        /// <inheritdoc />
        protected override void OnWsMessage(object sender, string message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message from Utility received: {message}", message);

            try
            {
                var json = JsonSerializer.Deserialize<JsonObject>(message);

                if (!json.TryGetPropertyValue("data", out var data) || data is null)
                    return;

                if (data.ToJsonString().Equals("\"Ok\"", StringComparison.OrdinalIgnoreCase))
                    return;

                if (data.AsObject().TryGetPropertyValue("Status", out var status) && status != null)
                {
                    var mixer = status["mixers"];
                    if (mixer != null)
                    {
                        var serialNumbers = mixer.AsObject().Select(pair => pair.Key).ToList();

                        foreach (var serialNumber in AvailableSerialNumbers)
                        {
                            if (!serialNumbers.Contains(serialNumber))
                                AvailableSerialNumbers.Remove(serialNumber);
                        }

                        foreach (var serialNumber in serialNumbers)
                        {
                            if (!AvailableSerialNumbers.Contains(serialNumber))
                                AvailableSerialNumbers.Add(serialNumber);
                        }
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
                        if (patch.JsonNode is null && AvailableSerialNumbers.Contains(pathSplit[2]))
                        {
                            AvailableSerialNumbers.Remove(pathSplit[2]);
                        }
                        else if (patch.JsonNode != null && !AvailableSerialNumbers.Contains(pathSplit[2]))
                        {
                            AvailableSerialNumbers.Add(pathSplit[2]);
                            TraverseObject(patch.JsonNode, $"/mixers/{pathSplit[2]}");
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
                                    OnPatch?.Invoke(this, new Patch { Op = OpPatchEnum.Replace, Path = prefix + ConvertPath(item.GetPath()), JsonNode = item});
                                    break;
                            }
                        }
                        break;
                    
                    default:
                        var value = property.Value?.AsValue();

                        if (value != null)
                            OnPatch?.Invoke(this, new Patch { Op = OpPatchEnum.Replace, Path = prefix + ConvertPath(property.Value?.GetPath()), JsonNode = property.Value});
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

            path = path.Substring(path.IndexOf('$') + 1);
            path = path.Replace(".data.Status", "");
            
            var startIndex = path.IndexOf("['", StringComparison.Ordinal);
            var endIndex = path.LastIndexOf("']", StringComparison.Ordinal) + 2;
            var prefix = "";
            var substring = "";
            if (startIndex != -1 && endIndex != -1)
            {
                prefix = path.Substring(0, startIndex).Replace(".", "/");
                var suffix = path.Substring(endIndex).Replace(".", "/");
                substring = path.Substring(startIndex, endIndex - startIndex);
                substring = substring.Replace("['", "\\\\").Replace("']", "");
                substring += suffix;
            }
            else
            {
                prefix = path.Replace(".", "/");
            }

            prefix = prefix.Replace("[", "/").Replace("]", "");
            path = prefix + substring;
            return path;
        }
    }
}