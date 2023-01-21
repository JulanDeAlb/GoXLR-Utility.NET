using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
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
            
        public event EventHandler<ByteDeviceEventArgs> OnChatVolumeChanged;

        public event EventHandler<ByteDeviceEventArgs> OnConsoleVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnGameVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnHeadphonesVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnLineInVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnLineOutVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnMicVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnMicMonitorVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnMusicVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnSampleVolumeChanged;
        
        public event EventHandler<ByteDeviceEventArgs> OnSystemVolumeChanged;
        
        protected internal void HandleEvents(string serialNumber, Volume volumes, Models.Response.Status.Mixer.Levels.Levels levels, MemberInfo memInfo)
        {
            var volumeEventArgs = new VolumeChangedEventArgs
            {
                SerialNumber = serialNumber
            };

            var byteDeviceEventArgs = new ByteDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Chat":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Chat;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Chat;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnChatVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Console":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Console;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Console;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnConsoleVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Game":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Game;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Game;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnGameVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Headphones":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Headphones;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Headphones;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnHeadphonesVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "LineIn":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.LineIn;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.LineIn;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineInVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "LineOut":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.LineOut;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.LineOut;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnLineOutVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Mic":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Mic;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Mic;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "MicMonitor":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.MicMonitor;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.MicMonitor;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMicMonitorVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Music":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Music;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Music;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnMusicVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "Sample":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.Sample;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.Sample;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSampleVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;
                
                case "System":
                    volumeEventArgs.TypeChanged = FaderChannelEnum.System;
                    volumeEventArgs.Value = byteDeviceEventArgs.Value = volumes.System;
                    OnVolumeChanged?.Invoke(this, volumeEventArgs);
                    OnSystemVolumeChanged?.Invoke(this, byteDeviceEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in VolumeEvents");
            }
        }
    }
}