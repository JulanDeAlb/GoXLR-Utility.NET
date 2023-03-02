using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.PresetNames
{
    public class PresetNames : INotifyPropertyChanged
    {
        private string _preset1 = null!;
        private string _preset2 = null!;
        private string _preset3 = null!;
        private string _preset4 = null!;
        private string _preset5 = null!;
        private string _preset6 = null!;
        
        [JsonPropertyName("Preset1")]
        public string Preset1
        {
            get => _preset1;
            set => SetField(ref _preset1, value);
        }
        
        [JsonPropertyName("Preset2")]
        public string Preset2
        {
            get => _preset2;
            set => SetField(ref _preset2, value);
        }
        
        [JsonPropertyName("Preset3")]
        public string Preset3
        {
            get => _preset3;
            set => SetField(ref _preset3, value);
        }
        
        [JsonPropertyName("Preset4")]
        public string Preset4
        {
            get => _preset4;
            set => SetField(ref _preset4, value);
        }
        
        [JsonPropertyName("Preset5")]
        public string Preset5
        {
            get => _preset5;
            set => SetField(ref _preset5, value);
        }
        
        [JsonPropertyName("Preset6")]
        public string Preset6
        {
            get => _preset6;
            set => SetField(ref _preset6, value);
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