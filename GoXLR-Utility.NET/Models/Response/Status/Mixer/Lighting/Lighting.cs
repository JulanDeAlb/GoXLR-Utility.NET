using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting
{
    //Path: mixer/SERIAL-NUMBER/lighting/...
    public class Lighting : INotifyPropertyChanged
    {
        private ButtonLight _button = null!;
        private EncoderLight _encoder = null!;
        private FaderLight _fader = null!;
        private SamplerLight _sampler = null!;
        private SimpleLight _simple = null!;
        
        [JsonPropertyName("buttons")]
        public ButtonLight Button
        {
            get => _button;
            set => SetField(ref _button, value);
        }
        
        [JsonPropertyName("encoders")]
        public EncoderLight Encoder
        {
            get => _encoder;
            set => SetField(ref _encoder, value);
        }
        
        [JsonPropertyName("faders")]
        public FaderLight Fader
        {
            get => _fader;
            set => SetField(ref _fader, value);
        }
        
        [JsonPropertyName("sampler")]
        public SamplerLight Sampler
        {
            get => _sampler;
            set => SetField(ref _sampler, value);
        }
        
        [JsonPropertyName("simple")]
        public SimpleLight Simple
        {
            get => _simple;
            set => SetField(ref _simple, value);
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