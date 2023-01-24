using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class HardTuneEffect : INotifyPropertyChanged
    {
        private int _amount;
        private bool _isEnabled;
        private int _rate;
        private HardTuneSource _source;
        private HardTuneStyle _style;
        private int _window;
        
        [JsonPropertyName("amount")]
        public int Amount
        {
            get => _amount;
            internal set => SetField(ref _amount, value);
        }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled
        {
            get => _isEnabled;
            internal set => SetField(ref _isEnabled, value);
        }
        
        [JsonPropertyName("rate")]
        public int Rate
        {
            get => _rate;
            internal set => SetField(ref _rate, value);
        }

        [JsonPropertyName("source")]
        public HardTuneSource Source
        {
            get => _source;
            internal set => SetField(ref _source, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public HardTuneStyle Style
        {
            get => _style;
            internal set => SetField(ref _style, value);
        }
        
        [JsonPropertyName("window")]
        public int Window
        {
            get => _window;
            internal set => SetField(ref _window, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}