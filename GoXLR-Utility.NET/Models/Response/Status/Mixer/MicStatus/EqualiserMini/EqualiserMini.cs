using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini
{
    public class EqualiserMini : INotifyPropertyChanged
    {
        private GainMini _gain;
        private FrequencyMini _frequency;
        
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