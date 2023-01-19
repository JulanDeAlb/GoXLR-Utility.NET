using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneEffectEvents
    {
        public event EventHandler<HardTuneEffectEventArgs> OnHardTuneEffectChanged;
        public event EventHandler<IntHardTuneEffectEventArgs> OnAmountChanged;
        public event EventHandler<BoolHardTuneEffectEventArgs> OnIsEnabledChanged;
        public event EventHandler<IntHardTuneEffectEventArgs> OnRateChanged;
        public event EventHandler<HardTuneSourceEffectEventArgs> OnSourceChanged;
        public event EventHandler<HardTuneStyleEffectEventArgs> OnStyleChanged;
        public event EventHandler<IntHardTuneEffectEventArgs> OnWindowChanged;

        protected internal void HandleEvents(string serialNumber, HardTuneEffect effect, MemberInfo memInfo)
        {
            var hardTuneEffectEventArgs = new HardTuneEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.Amount;
                    hardTuneEffectEventArgs.IntValue = effect.Amount;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new IntHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "IsEnabled":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.IsEnabled;
                    hardTuneEffectEventArgs.BoolValue = effect.IsEnabled;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
                    OnIsEnabledChanged?.Invoke(this, new BoolHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "Rate":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.Rate;
                    hardTuneEffectEventArgs.IntValue = effect.Rate;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
                    OnRateChanged?.Invoke(this, new IntHardTuneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Rate
                    });
                    break;
                
                case "Source":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.Source;
                    hardTuneEffectEventArgs.SourceValue = effect.Source;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
                    OnSourceChanged?.Invoke(this, new HardTuneSourceEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Source
                    });
                    break;

                case "Style":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.Style;
                    hardTuneEffectEventArgs.StyleValue = effect.Style;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
                    OnStyleChanged?.Invoke(this, new HardTuneStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                case "Window":
                    hardTuneEffectEventArgs.TypeChanged = HardTuneEnum.Window;
                    hardTuneEffectEventArgs.IntValue = effect.Window;
                    
                    OnHardTuneEffectChanged?.Invoke(this, hardTuneEffectEventArgs);
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