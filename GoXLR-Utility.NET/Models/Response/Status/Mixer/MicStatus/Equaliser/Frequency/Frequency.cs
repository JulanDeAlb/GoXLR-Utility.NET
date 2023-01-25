using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency
{
    public class Frequency : INotifyPropertyChanged
    {
        private double _equalizer31Hz;
        private double _equalizer63Hz;
        private double _equalizer125Hz;
        private double _equalizer250Hz;
        private double _equalizer500Hz;
        private double _equalizer1KHz;
        private double _equalizer2KHz;
        private double _equalizer4KHz;
        private double _equalizer8KHz;
        private double _equalizer16KHz;
        
        [JsonPropertyName("Equalizer31Hz")]
        public double Equalizer31Hz
        {
            get => _equalizer31Hz;
            set => SetField(ref _equalizer31Hz, value);
        }
        
        [JsonPropertyName("Equalizer63Hz")]
        public double Equalizer63Hz
        {
            get => _equalizer63Hz;
            set => SetField(ref _equalizer63Hz, value);
        }
        
        [JsonPropertyName("Equalizer125Hz")]
        public double Equalizer125Hz
        {
            get => _equalizer125Hz;
            set => SetField(ref _equalizer125Hz, value);
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
        
        [JsonPropertyName("Equalizer2KHz")]
        public double Equalizer2KHz
        {
            get => _equalizer2KHz;
            set => SetField(ref _equalizer2KHz, value);
        }
        
        [JsonPropertyName("Equalizer4KHz")]
        public double Equalizer4KHz
        {
            get => _equalizer4KHz;
            set => SetField(ref _equalizer4KHz, value);
        }
        
        [JsonPropertyName("Equalizer8KHz")]
        public double Equalizer8KHz
        {
            get => _equalizer8KHz;
            set => SetField(ref _equalizer8KHz, value);
        }
        
        [JsonPropertyName("Equalizer16KHz")]
        public double Equalizer16KHz
        {
            get => _equalizer16KHz;
            set => SetField(ref _equalizer16KHz, value);
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