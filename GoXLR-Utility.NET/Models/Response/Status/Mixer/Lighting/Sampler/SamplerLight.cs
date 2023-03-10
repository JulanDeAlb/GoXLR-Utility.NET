using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler
{
    //Path: mixer/SERIAL-NUMBER/lighting/sampler/...
    public class SamplerLight : INotifyPropertyChanged
    {
        private SamplerLightBase _samplerA;
        private SamplerLightBase _samplerB;
        private SamplerLightBase _samplerC;
        
        [JsonPropertyName("SamplerSelectA")]
        public SamplerLightBase SamplerA
        {
            get => _samplerA;
            set => SetField(ref _samplerA, value);
        }
        
        [JsonPropertyName("SamplerSelectB")]
        public SamplerLightBase SamplerB
        {
            get => _samplerB;
            set => SetField(ref _samplerB, value);
        }
        
        [JsonPropertyName("SamplerSelectC")]
        public SamplerLightBase SamplerC
        {
            get => _samplerC;
            set => SetField(ref _samplerC, value);
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
    
    public class SamplerLightBase : INotifyPropertyChanged
    {
        private LightingOffStyle _offStyle;
        private ThreeColour _colour;
        
        [JsonPropertyName("off_style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LightingOffStyle OffStyle
        {
            get => _offStyle;
            set => SetField(ref _offStyle, value);
        }
        
        [JsonPropertyName("colours")]
        public ThreeColour Colour
        {
            get => _colour;
            set => SetField(ref _colour, value);
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