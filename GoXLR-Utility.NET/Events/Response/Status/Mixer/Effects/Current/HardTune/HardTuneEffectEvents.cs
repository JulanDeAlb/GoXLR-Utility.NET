using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneEffectEvents
    {
        public event EventHandler<IntHardTuneEffectEventArgs> OnAmountChanged;
        public event EventHandler<BoolHardTuneEffectEventArgs> OnIsEnabledChanged;
        public event EventHandler<IntHardTuneEffectEventArgs> OnRateChanged;
        public event EventHandler<HardTuneSourceEffectEventArgs> OnSourceChanged;
        public event EventHandler<HardTuneStyleEffectEventArgs> OnStyleChanged;
        public event EventHandler<IntHardTuneEffectEventArgs> OnWindowChanged;

        protected internal void HandleEvents(string serialNumber, HardTuneEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<HardTuneEffectEventArgs> hardTuneChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.HardTune = new HardTuneEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.Amount;
                    effectEventArgs.Current.HardTune.IntValue = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnAmountChanged?.Invoke(this, new IntHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "IsEnabled":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.IsEnabled;
                    effectEventArgs.Current.HardTune.BoolValue = effect.IsEnabled;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnIsEnabledChanged?.Invoke(this, new BoolHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "Rate":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.Rate;
                    effectEventArgs.Current.HardTune.IntValue = effect.Rate;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnRateChanged?.Invoke(this, new IntHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Rate
                    });
                    break;
                
                case "Source":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.Source;
                    effectEventArgs.Current.HardTune.SourceValue = effect.Source;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnSourceChanged?.Invoke(this, new HardTuneSourceEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Source
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.Style;
                    effectEventArgs.Current.HardTune.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnStyleChanged?.Invoke(this, new HardTuneStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "Window":
                    effectEventArgs.Current.HardTune.TypeChanged = HardTuneEnum.Window;
                    effectEventArgs.Current.HardTune.IntValue = effect.Window;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    hardTuneChanged?.Invoke(this, effectEventArgs.Current.HardTune);
                    OnWindowChanged?.Invoke(this, new IntHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Window
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in HardTuneEffectEvents");
            }
        }
    }
}