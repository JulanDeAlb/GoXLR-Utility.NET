using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Gender
{
    public class GenderEffectEvents
    {
        public event EventHandler<GenderEffectEventArgs> OnGenderEffectChanged;
        public event EventHandler<SpecificGenderEffectEventArgs> OnAmountChanged;
        public event EventHandler<GenderEffectStyleEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, GenderEffect effect, MemberInfo memInfo)
        {
            var genderEffectEventArgs = new GenderEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    genderEffectEventArgs.TypeChanged = GenderEnum.Amount;
                    genderEffectEventArgs.Value = effect.Amount;
                    
                    OnGenderEffectChanged?.Invoke(this, genderEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new SpecificGenderEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "Style":
                    genderEffectEventArgs.TypeChanged = GenderEnum.Style;
                    genderEffectEventArgs.GenderStyle = effect.Style;
                    
                    OnGenderEffectChanged?.Invoke(this, genderEffectEventArgs);
                    OnStyleChanged?.Invoke(this, new GenderEffectStyleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in GenderEffectEvents");
            }
        }
}