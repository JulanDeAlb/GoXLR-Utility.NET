using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
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
            
        public event EventHandler<ByteVolumeChangedEventArgs> OnChatVolumeChanged;

        public event EventHandler<ByteVolumeChangedEventArgs> OnConsoleVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnGameVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnHeadphonesVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnLineInVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnLineOutVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnMicVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnMicMonitorVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnMusicVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnSampleVolumeChanged;
        
        public event EventHandler<ByteVolumeChangedEventArgs> OnSystemVolumeChanged;
        
        protected internal void HandleEvents(string serialNumber, Volume volumes, Models.Response.Status.Mixer.Levels.Levels levels, MemberInfo memInfo)
        {
            var volumeEventArgs = new VolumeChangedEventArgs
            {
                SerialNumber = serialNumber
            };

            var specVolumeEventArgs = new ByteVolumeChangedEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Chat":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Chat;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Chat;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnChatVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Console":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Console;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Console;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnConsoleVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Game":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Game;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Game;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnGameVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Headphones":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Headphones;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Headphones;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnHeadphonesVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "LineIn":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.LineIn;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.LineIn;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineInVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "LineOut":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.LineOut;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.LineOut;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineOutVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Mic":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Mic;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Mic;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "MicMonitor":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.MicMonitor;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.MicMonitor;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicMonitorVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Music":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Music;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Music;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMusicVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "Sample":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Sample;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.Sample;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSampleVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;
                
                case "System":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.System;
                    volumeEventArgs.Value = specVolumeEventArgs.Value = volumes.System;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSystemVolumeChanged?.Invoke(this, specVolumeEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in VolumeEvents");
            }
        }
    }
}