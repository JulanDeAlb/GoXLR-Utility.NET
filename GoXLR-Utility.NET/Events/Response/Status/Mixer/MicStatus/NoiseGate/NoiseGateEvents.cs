using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.NoiseGate
{
    /// <summary>
    /// <seealso cref="NoiseGate"/>
    /// </summary>
    public class NoiseGateEvents
    {
        public event EventHandler<IntDeviceEventArgs> OnAttackChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnAttenuationChanged;
        
        public event EventHandler<BoolDeviceEventArgs> OnEnabledChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnReleaseChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnThresholdChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.NoiseGate.NoiseGate noiseGate, MemberInfo memInfo,
            EventHandler<NoiseGateEventArgs> noiseGateChanged, NoiseGateEventArgs noiseGateEventArgs)
        {
            var intDeviceEventArgs = new IntDeviceEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Attack":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Attack;
                    noiseGateEventArgs.Value = intDeviceEventArgs.Value = noiseGate.Attack;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnAttackChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                case "Attenuation":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Attenuation;
                    noiseGateEventArgs.Value = intDeviceEventArgs.Value = noiseGate.Attenuation;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnAttenuationChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                case "Enabled":
                    var specBoolNoiseGateEventArgs = new BoolDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = noiseGate.Enabled
                    };
                    
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Enabled;
                    noiseGateEventArgs.BoolValue = specBoolNoiseGateEventArgs.Value = noiseGate.Enabled;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnEnabledChanged?.Invoke(this, specBoolNoiseGateEventArgs);
                    break;
                
                
                case "Release":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Release;
                    noiseGateEventArgs.Value = intDeviceEventArgs.Value = noiseGate.Release;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnReleaseChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                
                case "Threshold":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Threshold;
                    noiseGateEventArgs.Value = intDeviceEventArgs.Value = noiseGate.Threshold;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnThresholdChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in NoiseGateEvents");
            }
        }
    }
}