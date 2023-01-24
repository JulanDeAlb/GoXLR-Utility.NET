using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels
{
    //Path: mixer/SERIAL-NUMBER/levels/...
    public class Levels : INotifyPropertyChanged
    {
        private sbyte _bleep;
        private sbyte _deEsser;
        private Volume _volumes;
        
        [JsonPropertyName("bleep")]
        public sbyte Bleep
        {
            get => _bleep;
            internal set => SetField(ref _bleep, value);
        }
        
        [JsonPropertyName("deess")]
        public sbyte DeEsser
        {
            get => _deEsser;
            internal set => SetField(ref _deEsser, value);
        }
        
        [JsonPropertyName("volumes")]
        public Volume Volumes
        {
            get => _volumes;
            internal set => SetField(ref _volumes, value);
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