using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Config
{
    //Path: config/...
    public class Config : INotifyPropertyChanged
    {
        private string _daemonVersion;
        private bool _autostartEnabled;
        private bool _showTrayIcon;
        private bool _textToSpeechEnabled;

        [JsonPropertyName("daemon_version")]
        public string DaemonVersion
        {
            get => _daemonVersion;
            set => SetField(ref _daemonVersion, value);
        }
        
        [JsonPropertyName("autostart_enabled")]
        public bool AutostartEnabled
        {
            get => _autostartEnabled;
            set => SetField(ref _autostartEnabled, value);
        }
        
        [JsonPropertyName("show_tray_icon")]
        public bool ShowTrayIcon
        {
            get => _showTrayIcon;
            set => SetField(ref _showTrayIcon, value);
        }
        
        [JsonPropertyName("tts_enabled")]
        public bool TextToSpeechEnabled
        {
            get => _textToSpeechEnabled;
            set => SetField(ref _textToSpeechEnabled, value);
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