using System;
using System.Reflection;
using GoXLR_Utility.NET.EventArgs.Response.Status;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.CoughButton;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus;
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
        public MicStatusEvents Mic;
        public RouterEvents Router;
        public SamplerEvents Sampler;
        public SettingEvents Settings;
        public LevelEvents Levels;

        public MixerEvents()
        {
            ButtonDown = new ButtonDownEvents();
            CoughButton = new CoughButtonEvents();
            FaderStatus = new FaderStatusEvents();
            Mic = new MicStatusEvents();
            Router = new RouterEvents();
            Sampler = new SamplerEvents();
            Settings = new SettingEvents();
            Levels = new LevelEvents();
        }
        
        public event EventHandler<ProfileEventArgs> OnMicProfileChanged;
        public event EventHandler<ProfileEventArgs> OnProfileChanged;
        
        protected internal void HandleEvents(string serialNumber, Device device, MemberInfo memInfo)
        {
            var profileEventArgs = new ProfileEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "MicProfileName":
                    profileEventArgs.Value = device.MicProfileName;
                    OnMicProfileChanged?.Invoke(this, profileEventArgs);
                    break;
                
                case "ProfileName":
                    profileEventArgs.Value = device.MicProfileName;
                    OnProfileChanged?.Invoke(this, profileEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ");
            }
        }
    }
}