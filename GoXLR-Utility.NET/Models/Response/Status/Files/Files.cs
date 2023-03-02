using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Files
{
    //Path: files/...
    public class Files : INotifyPropertyChanged
    {
        private ObservableCollection<string> _icons = null!;
        private ObservableCollection<string> _micProfiles = null!;
        private ObservableCollection<string> _presets = null!;
        private ObservableCollection<string> _profiles = null!;
        private Dictionary<string, string> _samples = null!; //TODO Implement own ObservableDirectory
        
        [JsonPropertyName("icons")]
        public ObservableCollection<string> Icons
        {
            get => _icons;
            set => SetField(ref _icons, value);
        }
        
        [JsonPropertyName("mic_profiles")]
        public ObservableCollection<string> MicProfiles
        {
            get => _micProfiles;
            set => SetField(ref _micProfiles, value);
        }
        
        [JsonPropertyName("presets")]
        public ObservableCollection<string> Presets
        {
            get => _presets;
            set => SetField(ref _presets, value);
        }
        
        [JsonPropertyName("profiles")]
        public ObservableCollection<string> Profiles
        {
            get => _profiles;
            set => SetField(ref _profiles, value);
        }
        
        [JsonPropertyName("samples")]
        public Dictionary<string, string> Samples
        {
            get => _samples;
            set => SetField(ref _samples, value);
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