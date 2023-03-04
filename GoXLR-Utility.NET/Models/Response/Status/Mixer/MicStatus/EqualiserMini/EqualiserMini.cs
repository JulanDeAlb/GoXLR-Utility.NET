using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini
{
    //Path: mixer/SERIAL-NUMBER/mic_status/equaliser_mini/...
    public class EqualiserMini : INotifyPropertyChanged
    {
        private GainMini _gain = null!;
        private FrequencyMini _frequency = null!;
        
        [JsonPropertyName("gain")]
        public GainMini Gain
        {
            get => _gain;
            set => SetField(ref _gain, value);
        }
        
        [JsonPropertyName("frequency")]
        public FrequencyMini Frequency
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