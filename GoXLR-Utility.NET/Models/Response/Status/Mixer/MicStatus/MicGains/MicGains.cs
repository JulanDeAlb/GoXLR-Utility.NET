using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains
{
    //Path: mixer/SERIAL-NUMBER/mic_status/mic_gains/...
    public class MicGains : INotifyPropertyChanged
    {
        private int _condenser;
        private int _dynamic;
        private int _jack;
        
        [JsonPropertyName("Condenser")]
        public int Condenser
        {
            get => _condenser;
            set => SetField(ref _condenser, value);
        }
        
        [JsonPropertyName("Dynamic")]
        public int Dynamic
        {
            get => _dynamic;
            set => SetField(ref _dynamic, value);
        }
        
        [JsonPropertyName("Jack")]
        public int Jack
        {
            get => _jack;
            set => SetField(ref _jack, value);
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