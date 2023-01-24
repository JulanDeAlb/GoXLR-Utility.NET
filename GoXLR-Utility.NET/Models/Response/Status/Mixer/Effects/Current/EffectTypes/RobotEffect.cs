using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class RobotEffect : INotifyPropertyChanged
    {
        private int _dryMix;
        private bool _isEnabled;
        private int _highFreq;
        private int _highGain;
        private int _highWidth;
        private int _lowFreq;
        private int _lowGain;
        private int _lowWidth;
        private int _midFreq;
        private int _midGain;
        private int _midWidth;
        private int _pulseWidth;
        private RobotStyle _style;
        private int _threshold;
        private int _waveFrom;
        
        [JsonPropertyName("dry_mix")]
        public int DryMix
        {
            get => _dryMix;
            internal set => SetField(ref _dryMix, value);
        }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled
        {
            get => _isEnabled;
            internal set => SetField(ref _isEnabled, value);
        }
        
        [JsonPropertyName("high_freq")]
        public int HighFreq
        {
            get => _highFreq;
            internal set => SetField(ref _highFreq, value);
        }
        
        [JsonPropertyName("high_gain")]
        public int HighGain
        {
            get => _highGain;
            internal set => SetField(ref _highGain, value);
        }
        
        [JsonPropertyName("high_width")]
        public int HighWidth
        {
            get => _highWidth;
            internal set => SetField(ref _highWidth, value);
        }
        
        [JsonPropertyName("low_freq")]
        public int LowFreq
        {
            get => _lowFreq;
            internal set => SetField(ref _lowFreq, value);
        }
        
        [JsonPropertyName("low_gain")]
        public int LowGain
        {
            get => _lowGain;
            internal set => SetField(ref _lowGain, value);
        }
        
        [JsonPropertyName("low_width")]
        public int LowWidth
        {
            get => _lowWidth;
            internal set => SetField(ref _lowWidth, value);
        }
        
        [JsonPropertyName("mid_freq")]
        public int MidFreq
        {
            get => _midFreq;
            internal set => SetField(ref _midFreq, value);
        }
        
        [JsonPropertyName("mid_gain")]
        public int MidGain
        {
            get => _midGain;
            internal set => SetField(ref _midGain, value);
        }
        
        [JsonPropertyName("mid_width")]
        public int MidWidth
        {
            get => _midWidth;
            internal set => SetField(ref _midWidth, value);
        }
        
        [JsonPropertyName("pulse_width")]
        public int PulseWidth
        {
            get => _pulseWidth;
            internal set => SetField(ref _pulseWidth, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RobotStyle Style
        {
            get => _style;
            internal set => SetField(ref _style, value);
        }
        
        [JsonPropertyName("threshold")]
        public int Threshold
        {
            get => _threshold;
            internal set => SetField(ref _threshold, value);
        }

        [JsonPropertyName("waveform")]
        public int WaveFrom
        {
            get => _waveFrom;
            internal set => SetField(ref _waveFrom, value);
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