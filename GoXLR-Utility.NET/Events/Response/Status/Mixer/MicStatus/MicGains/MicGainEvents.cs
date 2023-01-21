using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.MicGains
{
    /// <summary>
    /// <seealso cref="MicGains"/>
    /// </summary>
    public class MicGainEvents
    {
        public event EventHandler<IntDeviceEventArgs> OnCondenserGainChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnDynamicGainChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnJackGainChanged;

        protected internal void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.MicGains.MicGains micGain, MemberInfo memInfo,
            EventHandler<MicGainEventArgs> gainsChanged, MicGainEventArgs micGainEventArgs)
        {
            var intDeviceEventArgs = new IntDeviceEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "Condenser":
                    micGainEventArgs.TypeChanged = MicrophoneType.Condenser;
                    micGainEventArgs.Value = intDeviceEventArgs.Value = micGain.Condenser;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnCondenserGainChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                case "Dynamic":
                    micGainEventArgs.TypeChanged = MicrophoneType.Dynamic;
                    micGainEventArgs.Value = intDeviceEventArgs.Value = micGain.Dynamic;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnDynamicGainChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                case "Jack":
                    micGainEventArgs.TypeChanged = MicrophoneType.Jack;
                    micGainEventArgs.Value = intDeviceEventArgs.Value = micGain.Jack;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnJackGainChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in MicGainEvents");
            }
        }
    }
}