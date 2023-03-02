using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Models.Response.Status
{
    public class Status : INotifyPropertyChanged
    {
        private Config.Config _config = null!;
        private Files.Files _files = null!;
        private Dictionary<string, Device> _mixers = null!; //TODO Implement own ObservableDirectory
        private Paths.Paths _paths = null!;
        
        [JsonPropertyName("config")]
        public Config.Config Config
        {
            get => _config;
            set => SetField(ref _config, value);
        }

        [JsonPropertyName("files")]
        public Files.Files Files
        {
            get => _files;
            set => SetField(ref _files, value);
        }
        
        [JsonPropertyName("mixers")]
        public Dictionary<string, Device> Mixers
        {
            get => _mixers;
            set => SetField(ref _mixers, value);
        }
        
        [JsonPropertyName("paths")]
        public Paths.Paths Paths
        {
            get => _paths;
            set => SetField(ref _paths, value);
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