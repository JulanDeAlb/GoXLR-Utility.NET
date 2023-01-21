using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.HttpSettings
{
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