using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class Sample : INotifyPropertyChanged
    {
        private string _name;
        private double _startPct;
        private double _stopPct;
        
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
        
        [JsonPropertyName("start_pct")]
        public double StartPct
        {
            get => _startPct;
            set => SetField(ref _startPct, value);
        }
        
        [JsonPropertyName("stop_pct")]
        public double StopPct
        {
            get => _stopPct;
            set => SetField(ref _stopPct, value);
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

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() != typeof(Sample))
                return false;

            var sample = (Sample)obj;

            return sample != null
                   && _name == sample._name
                   && _startPct.Equals(sample._startPct)
                   && _stopPct.Equals(sample._stopPct);
        }

        protected bool Equals(Sample other)
        {
            return _name == other._name && _startPct.Equals(other._startPct) && _stopPct.Equals(other._stopPct);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _name.GetHashCode();
                hashCode = (hashCode * 397) ^ _startPct.GetHashCode();
                hashCode = (hashCode * 397) ^ _stopPct.GetHashCode();
                return hashCode;
            }
        }
    }
}