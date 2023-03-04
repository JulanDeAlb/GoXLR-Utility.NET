using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders
{
    //Path: mixer/SERIAL-NUMBER/lighting/encoders/...
    public class EncoderLight : INotifyPropertyChanged
    {
        private ThreeColour _echo = null!;
        private ThreeColour _gender = null!;
        private ThreeColour _pitch = null!;
        private ThreeColour _reverb = null!;
        
        [JsonPropertyName("Echo")]
        public ThreeColour Echo
        {
            get => _echo;
            set => SetField(ref _echo, value);
        }
        
        [JsonPropertyName("Gender")]
        public ThreeColour Gender
        {
            get => _gender;
            set => SetField(ref _gender, value);
        }
        
        [JsonPropertyName("Pitch")]
        public ThreeColour Pitch
        {
            get => _pitch;
            set => SetField(ref _pitch, value);
        }
        
        [JsonPropertyName("Reverb")]
        public ThreeColour Reverb
        {
            get => _reverb;
            set => SetField(ref _reverb, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}