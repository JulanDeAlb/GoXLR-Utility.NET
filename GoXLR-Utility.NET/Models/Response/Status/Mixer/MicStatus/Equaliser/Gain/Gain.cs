using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    //Path: mixer/SERIAL-NUMBER/mic_status/equaliser/gain/...
    public class Gain : INotifyPropertyChanged
    {
        private int _equalizer31Hz;
        private int _equalizer63Hz;
        private int _equalizer125Hz;
        private int _equalizer250Hz;
        private int _equalizer500Hz;
        private int _equalizer1KHz;
        private int _equalizer2KHz;
        private int _equalizer4KHz;
        private int _equalizer8KHz;
        private int _equalizer16KHz;
        
        [JsonPropertyName("Equalizer31Hz")]
        public int Equalizer31Hz
        {
            get => _equalizer31Hz;
            set => SetField(ref _equalizer31Hz, value);
        }
        
        [JsonPropertyName("Equalizer63Hz")]
        public int Equalizer63Hz
        {
            get => _equalizer63Hz;
            set => SetField(ref _equalizer63Hz, value);
        }
        
        [JsonPropertyName("Equalizer125Hz")]
        public int Equalizer125Hz
        {
            get => _equalizer125Hz;
            set => SetField(ref _equalizer125Hz, value);
        }
        
        [JsonPropertyName("Equalizer250Hz")]
        public int Equalizer250Hz
        {
            get => _equalizer250Hz;
            set => SetField(ref _equalizer250Hz, value);
        }
        
        [JsonPropertyName("Equalizer500Hz")]
        public int Equalizer500Hz
        {
            get => _equalizer500Hz;
            set => SetField(ref _equalizer500Hz, value);
        }
        
        [JsonPropertyName("Equalizer1KHz")]
        public int Equalizer1KHz
        {
            get => _equalizer1KHz;
            set => SetField(ref _equalizer1KHz, value);
        }
        
        [JsonPropertyName("Equalizer2KHz")]
        public int Equalizer2KHz
        {
            get => _equalizer2KHz;
            set => SetField(ref _equalizer2KHz, value);
        }
        
        [JsonPropertyName("Equalizer4KHz")]
        public int Equalizer4KHz
        {
            get => _equalizer4KHz;
            set => SetField(ref _equalizer4KHz, value);
        }
        
        [JsonPropertyName("Equalizer8KHz")]
        public int Equalizer8KHz
        {
            get => _equalizer8KHz;
            set => SetField(ref _equalizer8KHz, value);
        }
        
        [JsonPropertyName("Equalizer16KHz")]
        public int Equalizer16KHz
        {
            get => _equalizer16KHz;
            set => SetField(ref _equalizer16KHz, value);
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