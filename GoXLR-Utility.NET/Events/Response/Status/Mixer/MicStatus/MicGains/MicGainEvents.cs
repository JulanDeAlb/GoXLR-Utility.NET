using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.MicGains
{
    /// <summary>
    /// <seealso cref="MicGains"/>
    /// </summary>
    public class MicGainEvents
    {
        public event EventHandler<IntMicGainEventArgs> OnCondenserGainChanged;
        
        public event EventHandler<IntMicGainEventArgs> OnDynamicGainChanged;
        
        public event EventHandler<IntMicGainEventArgs> OnJackGainChanged;

        protected internal void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.MicGains.MicGains micGain, MemberInfo memInfo,
            EventHandler<MicGainEventArgs> gainsChanged, MicGainEventArgs micGainEventArgs)
        {
            var intMicGainEventArgs = new IntMicGainEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "Condenser":
                    micGainEventArgs.TypeChanged = MicrophoneType.Condenser;
                    micGainEventArgs.Value = intMicGainEventArgs.Value = micGain.Condenser;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnCondenserGainChanged?.Invoke(this, intMicGainEventArgs);
                    break;
                
                case "Dynamic":
                    micGainEventArgs.TypeChanged = MicrophoneType.Dynamic;
                    micGainEventArgs.Value = intMicGainEventArgs.Value = micGain.Dynamic;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnDynamicGainChanged?.Invoke(this, intMicGainEventArgs);
                    break;
                
                case "Jack":
                    micGainEventArgs.TypeChanged = MicrophoneType.Jack;
                    micGainEventArgs.Value = intMicGainEventArgs.Value = micGain.Jack;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnJackGainChanged?.Invoke(this, intMicGainEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in MicGainEvents");
            }
        }
    }
}