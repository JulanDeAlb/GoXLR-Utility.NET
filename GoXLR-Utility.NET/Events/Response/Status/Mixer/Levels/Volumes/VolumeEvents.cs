using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels.Volumes
{
    /// <summary>
    /// <seealso cref="Volume"/>
    /// </summary>
    public class VolumeEvents
    {
        public event EventHandler<VolumeChangedEventArgs> OnVolumeChanged;

        public event EventHandler<SpecificVolumeChangedEventArgs> OnBleepVolumeChanged;
            
        public event EventHandler<SpecificVolumeChangedEventArgs> OnChatVolumeChanged;

        public event EventHandler<SpecificVolumeChangedEventArgs> OnConsoleVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnGameVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnHeadphonesVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnLineInVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnLineOutVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnMicVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnMicMonitorVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnMusicVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnSampleVolumeChanged;
        
        public event EventHandler<SpecificVolumeChangedEventArgs> OnSystemVolumeChanged;
        
        protected internal void HandleEvents(string serialNumber, Volume volumes, Models.Response.Status.Mixer.Levels.Levels levels, MemberInfo memInfo)
        {
            var volumeEventArgs = new VolumeChangedEventArgs
            {
                SerialNumber = serialNumber
            };

            var specVolumeEventArgs = new SpecificVolumeChangedEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    volumeEventArgs.Channel = ChannelEnum.Bleep;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = levels.Bleep;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnBleepVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Chat":
                    volumeEventArgs.Channel = ChannelEnum.Chat;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Chat;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnChatVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Console":
                    volumeEventArgs.Channel = ChannelEnum.Console;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Console;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnConsoleVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Game":
                    volumeEventArgs.Channel = ChannelEnum.Game;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Game;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnGameVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Headphones":
                    volumeEventArgs.Channel = ChannelEnum.Headphones;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Headphones;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnHeadphonesVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "LineIn":
                    volumeEventArgs.Channel = ChannelEnum.LineIn;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.LineIn;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineInVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "LineOut":
                    volumeEventArgs.Channel = ChannelEnum.LineOut;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.LineOut;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineOutVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Mic":
                    volumeEventArgs.Channel = ChannelEnum.Mic;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Mic;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "MicMonitor":
                    volumeEventArgs.Channel = ChannelEnum.MicMonitor;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.MicMonitor;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicMonitorVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Music":
                    volumeEventArgs.Channel = ChannelEnum.Music;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Music;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMusicVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Sample":
                    volumeEventArgs.Channel = ChannelEnum.Sample;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.Sample;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSampleVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "System":
                    volumeEventArgs.Channel = ChannelEnum.System;
                    volumeEventArgs.Volume = specVolumeEventArgs.Volume = volumes.System;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSystemVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in VolumeEvents");
            }
        }
    }
}