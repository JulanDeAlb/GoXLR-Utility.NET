using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Submix.SubmixInputs
{
    //Path: mixer/SERIAL-NUMBER/levels/submix/inputs/...
    public class SubmixInput : INotifyPropertyChanged
    {
        private bool _linked;
        private double _ratio;
        private byte _volume;
        
        [JsonPropertyName("linked")]
        public bool Linked
        {
            get => _linked;
            set => SetField(ref _linked, value);
        }
        
        [JsonPropertyName("ratio")]
        public double Ratio
        {
            get => _ratio;
            set => SetField(ref _ratio, value);
        }
        
        [JsonPropertyName("volume")]
        public byte Volume
        {
            get => _volume;
            set => SetField(ref _volume, value);
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