using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
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
            var specMicGainEventArgs = new IntMicGainEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "Condenser":
                    micGainEventArgs.TypeChanged = MicGainEnum.Condenser;
                    micGainEventArgs.Value = specMicGainEventArgs.Value = micGain.Condenser;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnCondenserGainChanged?.Invoke(this, specMicGainEventArgs);
                    break;
                
                case "Dynamic":
                    micGainEventArgs.TypeChanged = MicGainEnum.Dynamic;
                    micGainEventArgs.Value = specMicGainEventArgs.Value = micGain.Dynamic;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnDynamicGainChanged?.Invoke(this, specMicGainEventArgs);
                    break;
                
                case "Jack":
                    micGainEventArgs.TypeChanged = MicGainEnum.Jack;
                    micGainEventArgs.Value = specMicGainEventArgs.Value = micGain.Jack;
                    
                    gainsChanged?.Invoke(this, micGainEventArgs);
                    OnJackGainChanged?.Invoke(this, specMicGainEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in MicGainEvents");
            }
        }
    }
}