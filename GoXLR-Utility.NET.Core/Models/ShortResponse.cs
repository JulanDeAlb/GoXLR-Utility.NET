using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Core.Models
{
    public class ShortResponse
    {
        [JsonPropertyName("Status")]
        public Status Status { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("config")]
        public Config Config { get; set; }
    }

    public class Config
    {
        [JsonPropertyName("http_settings")]
        public HttpSettings HttpSettings { get; set; }
    }
    
    public class HttpSettings
    {
        [JsonPropertyName("bind_address")]
        public string BindAddress { get; set; }

        [JsonPropertyName("cors_enabled")]
        public bool CorsEnabled { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("port")]
        public int Port { get; set; }

        public string ToWebSocketString()
        {
            return BindAddress.Equals("0.0.0.0")
                ? $"ws://localhost:{Port}/api/websocket"
                : $"ws://{BindAddress}:{Port}/api/websocket";
        }
    }
}