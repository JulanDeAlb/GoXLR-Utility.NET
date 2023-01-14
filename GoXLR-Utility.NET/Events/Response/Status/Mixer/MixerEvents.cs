using System;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.CoughButton;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Router;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer
{
    public class MixerEvents
    {
        public ButtonDownEvents ButtonDown;
        public CoughButtonEvents CoughButton;
        public FaderStatusEvents FaderStatus;
        public RouterEvents Router;
        public SamplerEvents Sampler;
        public SettingEvents Settings;
        public VolumeEvents Volume;
        
        public event EventHandler<DevicesEventArgs> OnDevicesChanged;

        public MixerEvents()
        {
            ButtonDown = new ButtonDownEvents();
            CoughButton = new CoughButtonEvents();
            FaderStatus = new FaderStatusEvents();
            Router = new RouterEvents();
            Sampler = new SamplerEvents();
            Settings = new SettingEvents();
            Volume = new VolumeEvents();
        }
        
        public void HandleEvents(string serialNumber, Device value)
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