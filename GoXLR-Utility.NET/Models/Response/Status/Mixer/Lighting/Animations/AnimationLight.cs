using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Animatins;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Animations
{
    //Path: mixer/SERIAL-NUMBER/lighting/animation/...
    public class AnimationLight : INotifyPropertyChanged
    {
        private AnimationMode _mode;
        private int _mod1;
        private int _mod2;
        private bool _supported;
        private WaterfallDirection _waterfallDirection;

        [JsonPropertyName("mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AnimationMode Mode
        {
            get => _mode;
            set => SetField(ref _mode, value);
        }

        [JsonPropertyName("mod1")]
        public int Mod1
        {
            get => _mod1;
            set => SetField(ref _mod1, value);
        }

        [JsonPropertyName("mod2")]
        public int Mod2
        {
            get => _mod2;
            set => SetField(ref _mod2, value);
        }
        
        [JsonPropertyName("supported")]
        public bool Supported
        {
            get => _supported;
            set => SetField(ref _supported, value);
        }
        
        [JsonPropertyName("waterfall_direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WaterfallDirection WaterfallDirection
        {
            get => _waterfallDirection;
            set => SetField(ref _waterfallDirection, value);
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