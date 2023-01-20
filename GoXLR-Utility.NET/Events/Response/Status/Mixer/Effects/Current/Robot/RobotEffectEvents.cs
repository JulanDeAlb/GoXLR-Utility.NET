using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Robot
{
    public class RobotEffectEvents
    {
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

        protected internal void HandleEvents(string serialNumber, RobotEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<RobotEffectEventArgs> robotChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Robot = new RobotEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "DryMix":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.DryMix;
                    effectEventArgs.Current.Robot.IntValue = effect.DryMix;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnDryMixChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DryMix
                    });
                    break;
                
                case "IsEnabled":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.IsEnabled;
                    effectEventArgs.Current.Robot.BoolValue = effect.IsEnabled;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnIsEnabledChanged?.Invoke(this, new BoolRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "HighFreq":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.HighFreq;
                    effectEventArgs.Current.Robot.IntValue = effect.HighFreq;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnHighFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighFreq
                    });
                    break;
                
                case "HighGain":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.HighGain;
                    effectEventArgs.Current.Robot.IntValue = effect.HighGain;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnHighGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighGain
                    });
                    break;
                
                case "HighWidth":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.HighWidth;
                    effectEventArgs.Current.Robot.IntValue = effect.HighWidth;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnHighWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HighWidth
                    });
                    break;
                
                case "LowFreq":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.LowFreq;
                    effectEventArgs.Current.Robot.IntValue = effect.LowFreq;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnLowFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowFreq
                    });
                    break;
                
                case "LowGain":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.LowGain;
                    effectEventArgs.Current.Robot.IntValue = effect.LowGain;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnLowGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowGain
                    });
                    break;
                
                case "LowWidth":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.LowWidth;
                    effectEventArgs.Current.Robot.IntValue = effect.LowWidth;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnLowWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LowWidth
                    });
                    break;
                
                case "MidFreq":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.MidFreq;
                    effectEventArgs.Current.Robot.IntValue = effect.MidFreq;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnMidFreqChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidFreq
                    });
                    break;
                
                case "MidGain":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.MidGain;
                    effectEventArgs.Current.Robot.IntValue = effect.MidGain;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnMidGainChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidGain
                    });
                    break;

                case "MidWidth":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.MidWidth;
                    effectEventArgs.Current.Robot.IntValue = effect.MidWidth;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnMidWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.MidWidth
                    });
                    break;

                case "PulseWidth":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.PulseWidth;
                    effectEventArgs.Current.Robot.IntValue = effect.PulseWidth;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnPulseWidthChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PulseWidth
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.Style;
                    effectEventArgs.Current.Robot.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnStyleChanged?.Invoke(this, new RobotStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "Threshold":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.Threshold;
                    effectEventArgs.Current.Robot.IntValue = effect.Threshold;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
                    OnThresholdChanged?.Invoke(this, new IntRobotEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Threshold
                    });
                    break;

                case "WaveFrom":
                    effectEventArgs.Current.Robot.TypeChanged = RobotEnum.WaveFrom;
                    effectEventArgs.Current.Robot.IntValue = effect.WaveFrom;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    robotChanged?.Invoke(this, effectEventArgs.Current.Robot);
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