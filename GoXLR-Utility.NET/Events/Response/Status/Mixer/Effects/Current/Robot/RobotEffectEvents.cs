using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Robot
{
    public class ReverbEffectEvents
    {
        public event EventHandler<RobotEffectEventArgs>OnReverbEffectChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnDryMixChanged;
        public event EventHandler<BoolRobotEffectEventArgs> OnIsEnabledChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnHighFreqChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnHighGainChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnHighWidthChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnLowFreqChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnLowGainChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnLowWidthChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnMidFreqChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnMidGainChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnMidWidthChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnPulseWidthChanged;
        public event EventHandler<RobotStyleEffectEventArgs> OnStyleChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnThresholdChanged;
        public event EventHandler<IntRobotEffectEventArgs> OnWaveFromChanged;

        protected internal void HandleEvents(string serialNumber, RobotEffect effect, MemberInfo memInfo)
        {
            var robotEffectEventArgs = new RobotEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "DryMix":
                    robotEffectEventArgs.TypeChanged = RobotEnum.DryMix;
                    robotEffectEventArgs.IntValue = effect.DryMix;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnDryMixChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DryMix
                    });
                    break;
                
                case "IsEnabled":
                    robotEffectEventArgs.TypeChanged = RobotEnum.IsEnabled;
                    robotEffectEventArgs.IntValue = effect.IsEnabled;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnIsEnabledChanged?.Invoke(this, new BoolRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "HighFreq":
                    robotEffectEventArgs.TypeChanged = RobotEnum.HighFreq;
                    robotEffectEventArgs.IntValue = effect.HighFreq;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnHighFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighFreq
                    });
                    break;
                
                case "HighGain":
                    robotEffectEventArgs.TypeChanged = RobotEnum.HighGain;
                    robotEffectEventArgs.IntValue = effect.HighGain;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnHighGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighGain
                    });
                    break;
                
                case "HighWidth":
                    robotEffectEventArgs.TypeChanged = RobotEnum.HighWidth;
                    robotEffectEventArgs.IntValue = effect.HighWidth;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnHighWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighWidth
                    });
                    break;
                
                case "LowFreq":
                    robotEffectEventArgs.TypeChanged = RobotEnum.LowFreq;
                    robotEffectEventArgs.IntValue = effect.LowFreq;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnLowFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowFreq
                    });
                    break;
                
                case "LowGain":
                    robotEffectEventArgs.TypeChanged = RobotEnum.LowGain;
                    robotEffectEventArgs.IntValue = effect.LowGain;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnLowGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowGain
                    });
                    break;
                
                case "LowWidth":
                    robotEffectEventArgs.TypeChanged = RobotEnum.LowWidth;
                    robotEffectEventArgs.IntValue = effect.LowWidth;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnLowWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowWidth
                    });
                    break;
                
                case "MidFreq":
                    robotEffectEventArgs.TypeChanged = RobotEnum.MidFreq;
                    robotEffectEventArgs.IntValue = effect.MidFreq;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnMidFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidFreq
                    });
                    break;
                
                case "MidGain":
                    robotEffectEventArgs.TypeChanged = RobotEnum.MidGain;
                    robotEffectEventArgs.IntValue = effect.MidGain;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnMidGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidGain
                    });
                    break;

                case "MidWidth":
                    robotEffectEventArgs.TypeChanged = RobotEnum.MidWidth;
                    robotEffectEventArgs.StyleValue = effect.MidWidth;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnMidWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidWidth
                    });
                    break;

                case "PulseWidth":
                    robotEffectEventArgs.TypeChanged = RobotEnum.PulseWidth;
                    robotEffectEventArgs.IntValue = effect.PulseWidth;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnPulseWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PulseWidth
                    });
                    break;

                case "Style":
                    robotEffectEventArgs.TypeChanged = RobotEnum.Style;
                    robotEffectEventArgs.IntValue = effect.Style;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnStyleChanged?.Invoke(this, new RobotStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "Threshold":
                    robotEffectEventArgs.TypeChanged = RobotEnum.Threshold;
                    robotEffectEventArgs.IntValue = effect.Threshold;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnThresholdChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Threshold
                    });
                    break;

                case "WaveFrom":
                    robotEffectEventArgs.TypeChanged = RobotEnum.WaveFrom;
                    robotEffectEventArgs.IntValue = effect.WaveFrom;
                    
                    OnReverbEffectChanged?.Invoke(this, robotEffectEventArgs);
                    OnWaveFromChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.WaveFrom
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in RobotEffectEvents");
            }
        }
    }
}