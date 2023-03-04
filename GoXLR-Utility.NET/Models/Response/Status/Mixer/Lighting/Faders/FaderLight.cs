using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders
{
    //Path: mixer/SERIAL-NUMBER/lighting/faders/...
    public class FaderLight : INotifyPropertyChanged
    {
        private FaderLightBase _faderA = null!;
        private FaderLightBase _faderB = null!;
        private FaderLightBase _faderC = null!;
        private FaderLightBase _faderD = null!;
        
        [JsonPropertyName("A")]
        public FaderLightBase FaderA
        {
            get => _faderA;
            set => SetField(ref _faderA, value);
        }
        
        [JsonPropertyName("B")]
        public FaderLightBase FaderB
        {
            get => _faderB;
            set => SetField(ref _faderB, value);
        }
        
        [JsonPropertyName("C")]
        public FaderLightBase FaderC
        {
            get => _faderC;
            set => SetField(ref _faderC, value);
        }
        
        [JsonPropertyName("D")]
        public FaderLightBase FaderD
        {
            get => _faderD;
            set => SetField(ref _faderD, value);
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
    
    public class FaderLightBase : INotifyPropertyChanged
    {
        private TwoColour _colour = null!;
        private FaderDisplayStyle _style;
        
        [JsonPropertyName("colours")]
        public TwoColour Colour
        {
            get => _colour;
            set => SetField(ref _colour, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FaderDisplayStyle Style
        {
            get => _style;
            set => SetField(ref _style, value);
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