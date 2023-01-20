using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Pitch
{
   public class PitchEffectEvents
    {
        public event EventHandler<IntPitchEffectEventArgs> OnAmountChanged;
        public event EventHandler<IntPitchEffectEventArgs> OnCharacterChanged;
        public event EventHandler<PitchStyleEffectEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, PitchEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<PitchEffectEventArgs> pitchChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Pitch = new PitchEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.Pitch.TypeChanged = PitchEnum.Amount;
                    effectEventArgs.Current.Pitch.IntValue = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    pitchChanged?.Invoke(this, effectEventArgs.Current.Pitch);
                    OnAmountChanged?.Invoke(this, new IntPitchEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "Character":
                    effectEventArgs.Current.Pitch.TypeChanged = PitchEnum.Character;
                    effectEventArgs.Current.Pitch.IntValue = effect.Character;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    pitchChanged?.Invoke(this, effectEventArgs.Current.Pitch);
                    OnCharacterChanged?.Invoke(this, new IntPitchEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Character
                    });
                    break;

                case "Style":
                    effectEventArgs.Current.Pitch.TypeChanged = PitchEnum.Style;
                    effectEventArgs.Current.Pitch.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    pitchChanged?.Invoke(this, effectEventArgs.Current.Pitch);
                    OnStyleChanged?.Invoke(this, new PitchStyleEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in PitchEffectEvents");
            }
        }
    }
}