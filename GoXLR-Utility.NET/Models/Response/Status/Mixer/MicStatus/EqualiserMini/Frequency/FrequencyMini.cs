using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    //Path: mixer/SERIAL-NUMBER/mic_status/equaliser_mini/frequency...
    public class FrequencyMini : INotifyPropertyChanged
    {
        private double _equalizer90Hz;
        private double _equalizer250Hz;
        private double _equalizer500Hz;
        private double _equalizer1KHz;
        private double _equalizer3KHz;
        private double _equalizer8KHz;
        
        [JsonPropertyName("Equalizer90Hz")]
        public double Equalizer90Hz
        {
            get => _equalizer90Hz;
            set => SetField(ref _equalizer90Hz, value);
        }
        
        [JsonPropertyName("Equalizer250Hz")]
        public double Equalizer250Hz
        {
            get => _equalizer250Hz;
            set => SetField(ref _equalizer250Hz, value);
        }
        
        [JsonPropertyName("Equalizer500Hz")]
        public double Equalizer500Hz
        {
            get => _equalizer500Hz;
            set => SetField(ref _equalizer500Hz, value);
        }
        
        [JsonPropertyName("Equalizer1KHz")]
        public double Equalizer1KHz
        {
            get => _equalizer1KHz;
            set => SetField(ref _equalizer1KHz, value);
        }
        
        [JsonPropertyName("Equalizer3KHz")]
        public double Equalizer3KHz
        {
            get => _equalizer3KHz;
            set => SetField(ref _equalizer3KHz, value);
        }
        
        [JsonPropertyName("Equalizer8KHz")]
        public double Equalizer8KHz
        {
            get => _equalizer8KHz;
            set => SetField(ref _equalizer8KHz, value);
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