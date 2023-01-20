using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.NoiseGate
{
    /// <summary>
    /// <seealso cref="NoiseGate"/>
    /// </summary>
    public class NoiseGateEvents
    {
        public event EventHandler<IntNoiseGateEventArgs> OnAttackChanged;
        
        public event EventHandler<IntNoiseGateEventArgs> OnAttenuationChanged;
        
        public event EventHandler<BoolNoiseGateEventArgs> OnEnabledChanged;
        
        public event EventHandler<IntNoiseGateEventArgs> OnReleaseChanged;
        
        public event EventHandler<IntNoiseGateEventArgs> OnThresholdChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.NoiseGate.NoiseGate noiseGate, MemberInfo memInfo,
            EventHandler<NoiseGateEventArgs> noiseGateChanged, NoiseGateEventArgs noiseGateEventArgs)
        {
            var intNoiseGateEventArgs = new IntNoiseGateEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Attack":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Attack;
                    noiseGateEventArgs.Value = intNoiseGateEventArgs.Value = noiseGate.Attack;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnAttackChanged?.Invoke(this, intNoiseGateEventArgs);
                    break;
                
                case "Attenuation":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Attenuation;
                    noiseGateEventArgs.Value = intNoiseGateEventArgs.Value = noiseGate.Attenuation;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnAttenuationChanged?.Invoke(this, intNoiseGateEventArgs);
                    break;
                
                case "Enabled":
                    var specBoolNoiseGateEventArgs = new BoolNoiseGateEventArgs
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
                    noiseGateEventArgs.Value = intNoiseGateEventArgs.Value = noiseGate.Release;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnReleaseChanged?.Invoke(this, intNoiseGateEventArgs);
                    break;
                
                
                case "Threshold":
                    noiseGateEventArgs.TypeChanged = NoiseGateEnum.Threshold;
                    noiseGateEventArgs.Value = intNoiseGateEventArgs.Value = noiseGate.Threshold;
                    
                    noiseGateChanged?.Invoke(this, noiseGateEventArgs);
                    OnThresholdChanged?.Invoke(this, intNoiseGateEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in NoiseGateEvents");
            }
        }
    }
}