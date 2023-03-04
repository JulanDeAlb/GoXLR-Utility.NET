using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple
{
    //Path: mixer/SERIAL-NUMBER/lighting/simple/...
    public class SimpleLight : INotifyPropertyChanged
    {
        private OneColour _accent = null!;
        private OneColour _scribble1 = null!;
        private OneColour _scribble2 = null!;
        private OneColour _scribble3 = null!;
        private OneColour _scribble4 = null!;
        private OneColour _global = null!;

        [JsonPropertyName("Accent")]
        public OneColour Accent
        {
            get => _accent;
            set => SetField(ref _accent, value);
        }
        
        [JsonPropertyName("Scribble1")]
        public OneColour Scribble1
        {
            get => _scribble1;
            set => SetField(ref _scribble1, value);
        }
        
        [JsonPropertyName("Scribble2")]
        public OneColour Scribble2
        {
            get => _scribble2;
            set => SetField(ref _scribble2, value);
        }
        
        [JsonPropertyName("Scribble3")]
        public OneColour Scribble3
        {
            get => _scribble3;
            set => SetField(ref _scribble3, value);
        }
        
        [JsonPropertyName("Scribble4")]
        public OneColour Scribble4
        {
            get => _scribble4;
            set => SetField(ref _scribble4, value);
        }
        
        [JsonPropertyName("Global")]
        public OneColour Global
        {
            get => _global;
            set => SetField(ref _global, value);
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