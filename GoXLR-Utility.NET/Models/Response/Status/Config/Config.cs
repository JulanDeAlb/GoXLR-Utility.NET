using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Config;

namespace GoXLR_Utility.NET.Models.Response.Status.Config
{
    //Path: config/...
    public class Config : INotifyPropertyChanged
    {
        private string _daemonVersion;
        private bool _autostartEnabled;
        private bool _showTrayIcon;
        private bool _textToSpeechEnabled;
        private bool _allowNetworkAccess;
        private LogLevelEnum _logLevel;

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
        
        [JsonPropertyName("allow_network_access")]
        public bool AllowNetworkAccess
        {
            get => _allowNetworkAccess;
            set => SetField(ref _allowNetworkAccess, value);
        }
        
        [JsonPropertyName("log_level")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LogLevelEnum LogLevel
        {
            get => _logLevel;
            set => SetField(ref _logLevel, value);
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