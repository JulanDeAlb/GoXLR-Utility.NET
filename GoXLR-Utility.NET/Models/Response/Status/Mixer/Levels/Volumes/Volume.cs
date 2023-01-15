using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes
{
    //Path: mixer/SERIAL-NUMBER/levels/volumes/...
    
    /// <summary>
    /// <seealso cref="VolumeEvents"/>
    /// </summary>
    public class Volume
    {
        [JsonPropertyName("Chat")]
        public byte Chat { get; set; }
        
        [JsonPropertyName("Console")]
        public byte Console { get; set; }
        
        [JsonPropertyName("Game")]
        public byte Game { get; set; }
        
        [JsonPropertyName("Headphones")]
        public byte Headphones { get; set; }
        
        [JsonPropertyName("LineIn")]
        public byte LineIn { get; set; }
        
        [JsonPropertyName("LineOut")]
        public byte LineOut { get; set; }
        
        [JsonPropertyName("Mic")]
        public byte Mic { get; set; }
        
        [JsonPropertyName("MicMonitor")]
        public byte MicMonitor { get; set; }
        
        [JsonPropertyName("Music")]
        public byte Music { get; set; }
        
        [JsonPropertyName("Sample")]
        public byte Sample { get; set; }
        
        [JsonPropertyName("System")]
        public byte System { get; set; }
    }
}