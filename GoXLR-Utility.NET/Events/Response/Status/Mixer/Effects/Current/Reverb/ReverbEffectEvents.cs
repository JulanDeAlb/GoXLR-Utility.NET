using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Reverb
{
    public class ReverbEffectEvents
    {
        public event EventHandler<IntReverbEffectEventArgs> OnAmountChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnDecayChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnDiffuseChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnEarlyLevelChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnHiColourChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnHiFactorChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnLoColourChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnModDepthChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnModSpeedChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnPreDelayChanged;
        public event EventHandler<ReverbStyleEffectEventArgs> OnStyleChanged;
        public event EventHandler<IntReverbEffectEventArgs> OnTailLevelChanged;

        protected internal void HandleEvents(string serialNumber, ReverbEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<ReverbEffectEventArgs> reverbChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Reverb = new ReverbEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.Amount;
                    effectEventArgs.Current.Reverb.IntValue = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnAmountChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "Decay":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.Decay;
                    effectEventArgs.Current.Reverb.IntValue = effect.Decay;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnDecayChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Decay
                    });
                    break;
                
                case "Diffuse":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.Diffuse;
                    effectEventArgs.Current.Reverb.IntValue = effect.Diffuse;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnDiffuseChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Diffuse
                    });
                    break;
                
                case "EarlyLevel":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.EarlyLevel;
                    effectEventArgs.Current.Reverb.IntValue = effect.EarlyLevel;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnEarlyLevelChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.EarlyLevel
                    });
                    break;
                
                case "HiColour":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.HiColour;
                    effectEventArgs.Current.Reverb.IntValue = effect.HiColour;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnHiColourChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HiColour
                    });
                    break;
                
                case "HiFactor":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.HiFactor;
                    effectEventArgs.Current.Reverb.IntValue = effect.HiFactor;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnHiFactorChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HiFactor
                    });
                    break;
                
                case "LoColour":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.LoColour;
                    effectEventArgs.Current.Reverb.IntValue = effect.LoColour;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnLoColourChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LoColour
                    });
                    break;
                
                case "ModDepth":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.ModDepth;
                    effectEventArgs.Current.Reverb.IntValue = effect.ModDepth;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnModDepthChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.ModDepth
                    });
                    break;
                
                case "ModSpeed":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.ModSpeed;
                    effectEventArgs.Current.Reverb.IntValue = effect.ModSpeed;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnModSpeedChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.ModSpeed
                    });
                    break;
                
                case "PreDelay":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.PreDelay;
                    effectEventArgs.Current.Reverb.IntValue = effect.PreDelay;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnPreDelayChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PreDelay
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.Style;
                    effectEventArgs.Current.Reverb.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnStyleChanged?.Invoke(this, new ReverbStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "TailLevel":
                    effectEventArgs.Current.Reverb.TypeChanged = ReverbEnum.TailLevel;
                    effectEventArgs.Current.Reverb.IntValue = effect.TailLevel;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    reverbChanged?.Invoke(this, effectEventArgs.Current.Reverb);
                    OnTailLevelChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.TailLevel
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ReverbEffectEvents");
            }
        }
    }
}