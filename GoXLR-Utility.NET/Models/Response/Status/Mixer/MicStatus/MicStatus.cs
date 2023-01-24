using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus
{
    public class MicStatus : INotifyPropertyChanged
    {
        private Compressor.Compressor _compressor;
        private Equaliser.Equaliser _equaliser;
        private EqualiserMini.EqualiserMini _equaliserMini;
        private MicGains.MicGains _micGains;
        private NoiseGate.NoiseGate _noiseGate;
        private MicrophoneType _micType;
        
        [JsonPropertyName("compressor")]
        public Compressor.Compressor Compressor
        {
            get => _compressor;
            internal set => SetField(ref _compressor, value);
        }
        
        [JsonPropertyName("equaliser")]
        public Equaliser.Equaliser Equaliser
        {
            get => _equaliser;
            internal set => SetField(ref _equaliser, value);
        }
        
        [JsonPropertyName("equaliser_mini")]
        public EqualiserMini.EqualiserMini EqualiserMini
        {
            get => _equaliserMini;
            internal set => SetField(ref _equaliserMini, value);
        }
        
        [JsonPropertyName("mic_gains")]
        public MicGains.MicGains MicGains
        {
            get => _micGains;
            internal set => SetField(ref _micGains, value);
        }
        
        [JsonPropertyName("noise_gate")]
        public NoiseGate.NoiseGate NoiseGate
        {
            get => _noiseGate;
            internal set => SetField(ref _noiseGate, value);
        }
        
        [JsonPropertyName("mic_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MicrophoneType MicType
        {
            get => _micType;
            internal set => SetField(ref _micType, value);
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