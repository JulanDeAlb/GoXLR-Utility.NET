using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Models.Response.Status
{
    public class Status
    {
        [JsonPropertyName("config")]
        public Config.Config Config { get; set; }

        [JsonPropertyName("files")]
        public Files.Files Files { get; set; }
        
        [JsonPropertyName("mixers")]
        public Dictionary<string, Device> Mixers { get; set; }
        
        [JsonPropertyName("paths")]
        public Paths.Paths Paths { get; set; }
    }

    /*public class CommonEvents
    {
        public event EventHandler<DeviceEventArgs> OnFileChange;
        public event EventHandler<DeviceEventArgs> OnDeviceChange;
        public event EventHandler<DeviceEventArgs> OnPathChange;
        
        public void HandleDeviceEvents(string serialNumber, Device value)
        {
            OnDeviceChange?.Invoke(this, new DeviceEventArgs
            {
                SerialNumber = serialNumber,
                IsAdded = !(value is null),
                DeviceStatus = value
            });
        }
    }

    public class DeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// <b>True</b> - Device was added
        /// <b>False</b> - Device was removed
        /// </summary>
        public bool IsAdded { get; internal set; }
        
        public Device DeviceStatus { get; internal set; }
    }*/
}