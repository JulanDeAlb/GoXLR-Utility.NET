using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Models.Response.Status
{
    public class Status : INotifyPropertyChanged
    {
        private Config.Config _config;
        private Files.Files _files;
        private Dictionary<string, Device> _mixers; //TODO Implement own ObservableDirectory
        private Paths.Paths _paths;
        
        [JsonPropertyName("config")]
        public Config.Config Config
        {
            get => _config;
            internal set => SetField(ref _config, value);
        }

        [JsonPropertyName("files")]
        public Files.Files Files
        {
            get => _files;
            internal set => SetField(ref _files, value);
        }
        
        [JsonPropertyName("mixers")]
        public Dictionary<string, Device> Mixers
        {
            get => _mixers;
            internal set => SetField(ref _mixers, value);
        }
        
        [JsonPropertyName("paths")]
        public Paths.Paths Paths
        {
            get => _paths;
            internal set => SetField(ref _paths, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}