using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Gender
{
    public class GenderEffectEvents
    {
        public event EventHandler<IntGenderEffectEventArgs> OnAmountChanged;
        public event EventHandler<GenderEffectStyleEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, GenderEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<GenderEffectEventArgs> genderChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Gender = new GenderEffectEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.Gender.TypeChanged = GenderEnum.Amount;
                    effectEventArgs.Current.Gender.Value = effect.Amount;

                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    genderChanged?.Invoke(this, effectEventArgs.Current.Gender);
                    OnAmountChanged?.Invoke(this, new IntGenderEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.Gender.TypeChanged = GenderEnum.Style;
                    effectEventArgs.Current.Gender.StyleValue = effect.Style;

                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    genderChanged?.Invoke(this, effectEventArgs.Current.Gender);
                    OnStyleChanged?.Invoke(this, new GenderEffectStyleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in GenderEffectEvents");
            }
        }
    }
}