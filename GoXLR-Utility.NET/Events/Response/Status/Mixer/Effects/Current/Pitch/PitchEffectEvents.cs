using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Pitch
{
   public class PitchEffectEvents
    {
        public event EventHandler<PitchEffectEventArgs> OnPitchEffectChanged;
        public event EventHandler<IntPitchEffectEventArgs> OnAmountChanged;
        public event EventHandler<IntPitchEffectEventArgs> OnCharacterChanged;
        public event EventHandler<PitchStyleEffectEventArgs> OnStyleChanged;

        protected internal void HandleEvents(string serialNumber, PitchEffect effect, MemberInfo memInfo)
        {
            var pitchEffectEventArgs = new PitchEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    pitchEffectEventArgs.TypeChanged = PitchEnum.Amount;
                    pitchEffectEventArgs.IntValue = effect.Amount;
                    
                    OnPitchEffectChanged?.Invoke(this, pitchEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new IntPitchEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "Character":
                    pitchEffectEventArgs.TypeChanged = PitchEnum.Character;
                    pitchEffectEventArgs.IntValue = effect.Character;
                    
                    OnPitchEffectChanged?.Invoke(this, pitchEffectEventArgs);
                    OnCharacterChanged?.Invoke(this, new IntPitchEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Character
                    });
                    break;

                case "Style":
                    pitchEffectEventArgs.TypeChanged = PitchEnum.Style;
                    pitchEffectEventArgs.StyleValue = effect.Style;
                    
                    OnPitchEffectChanged?.Invoke(this, pitchEffectEventArgs);
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