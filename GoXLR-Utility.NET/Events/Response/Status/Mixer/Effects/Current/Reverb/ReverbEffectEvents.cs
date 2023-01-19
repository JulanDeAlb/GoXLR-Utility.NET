using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Reverb
{
    public class ReverbEffectEvents
    {
        public event EventHandler<ReverbEffectEventArgs> OnReverbEffectChanged;
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

        protected internal void HandleEvents(string serialNumber, ReverbEffect effect, MemberInfo memInfo)
        {
            var reverbEffectEventArgs = new ReverbEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.Amount;
                    reverbEffectEventArgs.IntValue = effect.Amount;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "Decay":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.Decay;
                    reverbEffectEventArgs.IntValue = effect.Decay;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnDecayChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Decay
                    });
                    break;
                
                case "Diffuse":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.Diffuse;
                    reverbEffectEventArgs.IntValue = effect.Diffuse;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnDiffuseChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Diffuse
                    });
                    break;
                
                case "EarlyLevel":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.EarlyLevel;
                    reverbEffectEventArgs.IntValue = effect.EarlyLevel;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnEarlyLevelChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.EarlyLevel
                    });
                    break;
                
                case "HiColour":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.HiColour;
                    reverbEffectEventArgs.IntValue = effect.HiColour;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnHiColourChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HiColour
                    });
                    break;
                
                case "HiFactor":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.HiFactor;
                    reverbEffectEventArgs.IntValue = effect.HiFactor;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnHiFactorChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.HiFactor
                    });
                    break;
                
                case "LoColour":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.LoColour;
                    reverbEffectEventArgs.IntValue = effect.LoColour;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnLoColourChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.LoColour
                    });
                    break;
                
                case "ModDepth":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.ModDepth;
                    reverbEffectEventArgs.IntValue = effect.ModDepth;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnModDepthChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.ModDepth
                    });
                    break;
                
                case "ModSpeed":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.ModSpeed;
                    reverbEffectEventArgs.IntValue = effect.ModSpeed;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnModSpeedChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.ModSpeed
                    });
                    break;
                
                case "PreDelay":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.PreDelay;
                    reverbEffectEventArgs.IntValue = effect.PreDelay;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnPreDelayChanged?.Invoke(this, new IntReverbEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PreDelay
                    });
                    break;

                case "Style":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.Style;
                    reverbEffectEventArgs.StyleValue = effect.Style;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
                    OnStyleChanged?.Invoke(this, new ReverbStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "TailLevel":
                    reverbEffectEventArgs.TypeChanged = ReverbEnum.TailLevel;
                    reverbEffectEventArgs.IntValue = effect.TailLevel;
                    
                    OnReverbEffectChanged?.Invoke(this, reverbEffectEventArgs);
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