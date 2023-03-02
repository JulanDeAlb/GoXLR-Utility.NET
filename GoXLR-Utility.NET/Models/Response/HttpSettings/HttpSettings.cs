using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.HttpSettings
{
    public class HttpSettings : INotifyPropertyChanged
    {
        private string _bindAddress = null!;
        private bool _corsEnabled;
        private bool _enabled;
        private int _port;
        
        [JsonPropertyName("bind_address")]
        public string BindAddress
        {
            get => _bindAddress;
            set => SetField(ref _bindAddress, value);
        }
        
        [JsonPropertyName("cors_enabled")]
        public bool CorsEnabled
        {
            get => _corsEnabled;
            set => SetField(ref _corsEnabled, value);
        }
        
        [JsonPropertyName("enabled")]
        public bool Enabled
        {
            get => _enabled;
            set => SetField(ref _enabled, value);
        }
        
        [JsonPropertyName("port")]
        public int Port
        {
            get => _port;
            set => SetField(ref _port, value);
        }

        public string ToWebSocketString()
        {
            return BindAddress.Equals("0.0.0.0")
                ? $"ws://localhost:{Port}/api/websocket"
                : $"ws://{BindAddress}:{Port}/api/websocket";
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