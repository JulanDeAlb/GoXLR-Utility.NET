using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

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

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}