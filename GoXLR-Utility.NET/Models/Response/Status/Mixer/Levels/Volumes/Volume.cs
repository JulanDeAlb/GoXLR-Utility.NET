using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes
{
    public class Volume
    {
        [JsonPropertyName("Chat")]
        public int Chat { get; set; }
        
        [JsonPropertyName("Console")]
        public int Console { get; set; }
        
        [JsonPropertyName("Game")]
        public int Game { get; set; }
        
        [JsonPropertyName("Headphones")]
        public int Headphones { get; set; }
        
        [JsonPropertyName("LineIn")]
        public int LineIn { get; set; }
        
        [JsonPropertyName("LineOut")]
        public int LineOut { get; set; }
        
        [JsonPropertyName("Mic")]
        public int Mic { get; set; }
        
        [JsonPropertyName("MicMonitor")]
        public int MicMonitor { get; set; }
        
        [JsonPropertyName("Music")]
        public int Music { get; set; }
        
        [JsonPropertyName("Sample")]
        public int Sample { get; set; }
        
        [JsonPropertyName("System")]
        public int System { get; set; }
    }
}