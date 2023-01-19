using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class MegaphoneEffectEvents
    {
        public event EventHandler<MegaphoneEffectEventArgs> OnMegaphoneEffectChanged;
        public event EventHandler<IntMegaphoneEffectEventArgs> OnAmountChanged;
        public event EventHandler<BoolMegaphoneEffectEventArgs> OnIsEnabledChanged;
        public event EventHandler<IntMegaphoneEffectEventArgs> OnRateChanged;
        public event EventHandler<MegaphoneStyleEffectEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, MegaphoneEffect effect, MemberInfo memInfo)
        {
            var megaphoneEffectEventArgs = new MegaphoneEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    megaphoneEffectEventArgs.TypeChanged = MegaphoneEnum.Amount;
                    megaphoneEffectEventArgs.IntValue = effect.Amount;
                    
                    OnMegaphoneEffectChanged?.Invoke(this, megaphoneEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new IntMegaphoneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "IsEnabled":
                    megaphoneEffectEventArgs.TypeChanged = MegaphoneEnum.IsEnabled;
                    megaphoneEffectEventArgs.BoolValue = effect.IsEnabled;
                    
                    OnMegaphoneEffectChanged?.Invoke(this, megaphoneEffectEventArgs);
                    OnIsEnabledChanged?.Invoke(this, new BoolMegaphoneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.IsEnabled
                    });
                    break;
                
                case "PostGain":
                    megaphoneEffectEventArgs.TypeChanged = MegaphoneEnum.PostGain;
                    megaphoneEffectEventArgs.IntValue = effect.PostGain;
                    
                    OnMegaphoneEffectChanged?.Invoke(this, megaphoneEffectEventArgs);
                    OnRateChanged?.Invoke(this, new IntMegaphoneEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.PostGain
                    });
                    break;

                case "Style":
                    megaphoneEffectEventArgs.TypeChanged = MegaphoneEnum.Style;
                    megaphoneEffectEventArgs.StyleValue = effect.Style;
                    
                    OnMegaphoneEffectChanged?.Invoke(this, megaphoneEffectEventArgs);
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