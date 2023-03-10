using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler
{
    //Path: mixer/SERIAL-NUMBER/sampler/...
    public class Sampler : INotifyPropertyChanged
    {
        private Banks.SamplerBanks _samplerBanks;

        [JsonPropertyName("banks")]
        public Banks.SamplerBanks SamplerBanks
        {
            get => _samplerBanks;
            set => SetField(ref _samplerBanks, value);
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