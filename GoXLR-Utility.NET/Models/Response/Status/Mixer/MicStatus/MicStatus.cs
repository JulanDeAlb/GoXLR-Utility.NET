using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus
{
    //Path: mixer/SERIAL-NUMBER/mic_status/...
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
            set => SetField(ref _compressor, value);
        }
        
        [JsonPropertyName("equaliser")]
        public Equaliser.Equaliser Equaliser
        {
            get => _equaliser;
            set => SetField(ref _equaliser, value);
        }
        
        [JsonPropertyName("equaliser_mini")]
        public EqualiserMini.EqualiserMini EqualiserMini
        {
            get => _equaliserMini;
            set => SetField(ref _equaliserMini, value);
        }
        
        [JsonPropertyName("mic_gains")]
        public MicGains.MicGains MicGains
        {
            get => _micGains;
            set => SetField(ref _micGains, value);
        }
        
        [JsonPropertyName("noise_gate")]
        public NoiseGate.NoiseGate NoiseGate
        {
            get => _noiseGate;
            set => SetField(ref _noiseGate, value);
        }
        
        [JsonPropertyName("mic_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MicrophoneType MicType
        {
            get => _micType;
            set => SetField(ref _micType, value);
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