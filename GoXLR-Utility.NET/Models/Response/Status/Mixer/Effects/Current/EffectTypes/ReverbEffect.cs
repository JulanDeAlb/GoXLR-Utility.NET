using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class ReverbEffect : INotifyPropertyChanged
    {
        private int _amount;
        private int _decay;
        private int _diffuse;
        private int _earlyLevel;
        private int _hiColour;
        private int _hiFactor;
        private int _loColour;
        private int _modDepth;
        private int _modSpeed;
        private int _preDelay;
        private ReverbStyle _style;
        private int _tailLevel;
        
        [JsonPropertyName("amount")]
        public int Amount
        {
            get => _amount;
            internal set => SetField(ref _amount, value);
        }
        
        [JsonPropertyName("decay")]
        public int Decay
        {
            get => _decay;
            internal set => SetField(ref _decay, value);
        }
        
        [JsonPropertyName("diffuse")]
        public int Diffuse
        {
            get => _diffuse;
            internal set => SetField(ref _diffuse, value);
        }
        
        [JsonPropertyName("early_level")]
        public int EarlyLevel
        {
            get => _earlyLevel;
            internal set => SetField(ref _earlyLevel, value);
        }
        
        [JsonPropertyName("hi_colour")]
        public int HiColour
        {
            get => _hiColour;
            internal set => SetField(ref _hiColour, value);
        }
        
        [JsonPropertyName("hi_factor")]
        public int HiFactor
        {
            get => _hiFactor;
            internal set => SetField(ref _hiFactor, value);
        }
        
        [JsonPropertyName("lo_colour")]
        public int LoColour
        {
            get => _loColour;
            internal set => SetField(ref _loColour, value);
        }
        
        [JsonPropertyName("mod_depth")]
        public int ModDepth
        {
            get => _modDepth;
            internal set => SetField(ref _modDepth, value);
        }
        
        [JsonPropertyName("mod_speed")]
        public int ModSpeed
        {
            get => _modSpeed;
            internal set => SetField(ref _modSpeed, value);
        }
        
        [JsonPropertyName("pre_delay")]
        public int PreDelay
        {
            get => _preDelay;
            internal set => SetField(ref _preDelay, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReverbStyle Style
        {
            get => _style;
            internal set => SetField(ref _style, value);
        }
        
        [JsonPropertyName("tail_level")]
        public int TailLevel
        {
            get => _tailLevel;
            internal set => SetField(ref _tailLevel, value);
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