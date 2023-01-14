using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders
{
    public class EncodersLight
    {
        [JsonPropertyName("Echo")]
        public ThreeColour Echo { get; set; }
        
        [JsonPropertyName("Gender")]
        public ThreeColour Gender { get; set; }
        
        [JsonPropertyName("Pitch")]
        public ThreeColour Pitch { get; set; }
        
        [JsonPropertyName("Reverb")]
        public ThreeColour Reverb { get; set; }
    }
}