using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor
{
    public class Compressor : INotifyPropertyChanged
    {
        private int _attack;
        private int _makeUpGain;
        private int _ratio;
        private int _release;
        private int _threshold;
        
        [JsonPropertyName("attack")]
        public int Attack
        {
            get => _attack;
            set => SetField(ref _attack, value);
        }
        
        [JsonPropertyName("makeup_gain")]
        public int MakeUpGain
        {
            get => _makeUpGain;
            set => SetField(ref _makeUpGain, value);
        }

        [JsonPropertyName("ratio")]
        public int Ratio
        {
            get => _ratio;
            set => SetField(ref _ratio, value);
        }
        
        [JsonPropertyName("release")]
        public int Release
        {
            get => _release;
            set => SetField(ref _release, value);
        }
        
        [JsonPropertyName("threshold")]
        public int Threshold
        {
            get => _threshold;
            set => SetField(ref _threshold, value);
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