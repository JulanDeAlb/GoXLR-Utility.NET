using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Paths
{
    //Path: paths/...
    public class Paths : INotifyPropertyChanged
    {
        private string _iconsDirectory;
        private string _micProfileDirectory;
        private string _presetsDirectory;
        private string _profileDirectory;
        private string _samplesDirectory;
        
        [JsonPropertyName("icons_directory")]
        public string IconsDirectory
        {
            get => _iconsDirectory;
            set => SetField(ref _iconsDirectory, value);
        }
        
        [JsonPropertyName("mic_profile_directory")]
        public string MicProfileDirectory
        {
            get => _micProfileDirectory;
            set => SetField(ref _micProfileDirectory, value);
        }
        
        [JsonPropertyName("presets_directory")]
        public string PresetsDirectory
        {
            get => _presetsDirectory;
            set => SetField(ref _presetsDirectory, value);
        }
        
        [JsonPropertyName("profile_directory")]
        public string ProfileDirectory
        {
            get => _profileDirectory;
            set => SetField(ref _profileDirectory, value);
        }
        
        [JsonPropertyName("samples_directory")]
        public string SamplesDirectory
        {
            get => _samplesDirectory;
            set => SetField(ref _samplesDirectory, value);
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