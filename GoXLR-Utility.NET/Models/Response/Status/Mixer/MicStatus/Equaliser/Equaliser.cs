using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser
{
    public class Equaliser : INotifyPropertyChanged
    {
        private Gain.Gain _gain = null!;
        private Frequency.Frequency _frequency = null!;
        
        [JsonPropertyName("gain")]
        public Gain.Gain Gain
        {
            get => _gain;
            set => SetField(ref _gain, value);
        }
        
        [JsonPropertyName("frequency")]
        public Frequency.Frequency Frequency
        {
            get => _frequency;
            set => SetField(ref _frequency, value);
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