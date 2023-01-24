using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class NoiseGate : INotifyPropertyChanged
    {
        private int _attack;
        private int _attenuation;
        private bool _enabled;
        private int _release;
        private int _threshold;
        
        [JsonPropertyName("attack")]
        public int Attack
        {
            get => _attack;
            internal set => SetField(ref _attack, value);
        }
        
        [JsonPropertyName("attenuation")]
        public int Attenuation
        {
            get => _attenuation;
            internal set => SetField(ref _attenuation, value);
        }
        
        [JsonPropertyName("enabled")]
        public bool Enabled
        {
            get => _enabled;
            internal set => SetField(ref _enabled, value);
        }
        
        [JsonPropertyName("release")]
        public int Release
        {
            get => _release;
            internal set => SetField(ref _release, value);
        }
        
        [JsonPropertyName("threshold")]
        public int Threshold
        {
            get => _threshold;
            internal set => SetField(ref _threshold, value);
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