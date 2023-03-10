using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    //Path: mixer/SERIAL-NUMBER/effects/preset_names/current/robot/...
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
            set => SetField(ref _dryMix, value);
        }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetField(ref _isEnabled, value);
        }
        
        [JsonPropertyName("high_freq")]
        public int HighFreq
        {
            get => _highFreq;
            set => SetField(ref _highFreq, value);
        }
        
        [JsonPropertyName("high_gain")]
        public int HighGain
        {
            get => _highGain;
            set => SetField(ref _highGain, value);
        }
        
        [JsonPropertyName("high_width")]
        public int HighWidth
        {
            get => _highWidth;
            set => SetField(ref _highWidth, value);
        }
        
        [JsonPropertyName("low_freq")]
        public int LowFreq
        {
            get => _lowFreq;
            set => SetField(ref _lowFreq, value);
        }
        
        [JsonPropertyName("low_gain")]
        public int LowGain
        {
            get => _lowGain;
            set => SetField(ref _lowGain, value);
        }
        
        [JsonPropertyName("low_width")]
        public int LowWidth
        {
            get => _lowWidth;
            set => SetField(ref _lowWidth, value);
        }
        
        [JsonPropertyName("mid_freq")]
        public int MidFreq
        {
            get => _midFreq;
            set => SetField(ref _midFreq, value);
        }
        
        [JsonPropertyName("mid_gain")]
        public int MidGain
        {
            get => _midGain;
            set => SetField(ref _midGain, value);
        }
        
        [JsonPropertyName("mid_width")]
        public int MidWidth
        {
            get => _midWidth;
            set => SetField(ref _midWidth, value);
        }
        
        [JsonPropertyName("pulse_width")]
        public int PulseWidth
        {
            get => _pulseWidth;
            set => SetField(ref _pulseWidth, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RobotStyle Style
        {
            get => _style;
            set => SetField(ref _style, value);
        }
        
        [JsonPropertyName("threshold")]
        public int Threshold
        {
            get => _threshold;
            set => SetField(ref _threshold, value);
        }

        [JsonPropertyName("waveform")]
        public int WaveFrom
        {
            get => _waveFrom;
            set => SetField(ref _waveFrom, value);
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