using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    //Path: mixer/SERIAL-NUMBER/effects/preset_names/current/pitch/...
    public class PitchEffect : INotifyPropertyChanged
    {
        private int _amount;
        private int _character;
        private PitchStyle _style;
        
        [JsonPropertyName("amount")]
        public int Amount
        {
            get => _amount;
            set => SetField(ref _amount, value);
        }
        
        [JsonPropertyName("character")]
        public int Character
        {
            get => _character;
            set => SetField(ref _character, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PitchStyle Style
        {
            get => _style;
            set => SetField(ref _style, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}