using System;
using GoXLR_Utility.NET.EventArgs.Response.Status;
using GoXLR_Utility.NET.Events.Response.Status.Config;
using GoXLR_Utility.NET.Events.Response.Status.Files;
using GoXLR_Utility.NET.Events.Response.Status.Mixer;
using GoXLR_Utility.NET.Events.Response.Status.Paths;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Events
{
    public class Events
    {
        public ConfigEvents Config;
        public FileEvents File;
        public MixerEvents Device;
        public PathEvents Path;

        public Events()
        {
            Config = new ConfigEvents();
            File = new FileEvents();
            Device = new MixerEvents();
            Path = new PathEvents();
        }
        
        public event EventHandler<DevicesEventArgs> OnDevicesChanged;
        
        protected internal void HandleEvents(string serialNumber, Device value)
        {
            OnDevicesChanged?.Invoke(this, new DevicesEventArgs
            {
                SerialNumber = serialNumber,
                IsAdded = !(value is null),
                DeviceStatus = value
            });
        }
    }
}