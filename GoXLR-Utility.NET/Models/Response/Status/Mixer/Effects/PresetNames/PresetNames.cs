using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.PresetNames
{
    public class PresetNames
    {
        [JsonPropertyName("Preset1")]
        public string Preset1 { get; set; }
        
        [JsonPropertyName("Preset2")]
        public string Preset2 { get; set; }
        
        [JsonPropertyName("Preset3")]
        public string Preset3 { get; set; }
        
        [JsonPropertyName("Preset4")]
        public string Preset4 { get; set; }
        
        [JsonPropertyName("Preset5")]
        public string Preset5 { get; set; }
        
        [JsonPropertyName("Preset6")]
        public string Preset6 { get; set; }
    }
}