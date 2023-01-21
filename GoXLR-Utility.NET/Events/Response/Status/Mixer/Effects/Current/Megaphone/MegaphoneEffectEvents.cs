using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class MegaphoneEffectEvents
    {
        public event EventHandler<IntDeviceEventArgs> OnAmountChanged;
        public event EventHandler<BoolDeviceEventArgs> OnIsEnabledChanged;
        public event EventHandler<IntDeviceEventArgs> OnRateChanged;
        public event EventHandler<MegaphoneStyleEffectEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, MegaphoneEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<MegaphoneEffectEventArgs> megaphoneChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Megaphone = new MegaphoneEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.Megaphone.TypeChanged = MegaphoneEnum.Amount;
                    effectEventArgs.Current.Megaphone.IntValue = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    megaphoneChanged?.Invoke(this, effectEventArgs.Current.Megaphone);
                    OnAmountChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "IsEnabled":
                    effectEventArgs.Current.Megaphone.TypeChanged = MegaphoneEnum.IsEnabled;
                    effectEventArgs.Current.Megaphone.BoolValue = effect.IsEnabled;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    megaphoneChanged?.Invoke(this, effectEventArgs.Current.Megaphone);
                    OnIsEnabledChanged?.Invoke(this, new BoolDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "PostGain":
                    effectEventArgs.Current.Megaphone.TypeChanged = MegaphoneEnum.PostGain;
                    effectEventArgs.Current.Megaphone.IntValue = effect.PostGain;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    megaphoneChanged?.Invoke(this, effectEventArgs.Current.Megaphone);
                    OnRateChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PostGain
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.Megaphone.TypeChanged = MegaphoneEnum.Style;
                    effectEventArgs.Current.Megaphone.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    megaphoneChanged?.Invoke(this, effectEventArgs.Current.Megaphone);
                    OnStyleChanged?.Invoke(this, new MegaphoneStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in MegaphoneEffectEvents");
            }
        }
    }
}