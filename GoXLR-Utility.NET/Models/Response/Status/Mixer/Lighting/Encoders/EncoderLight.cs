using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders
{
    public class EncoderLight
    {
        [JsonPropertyName("Echo")]
        public EchoColour Echo { get; set; }
        
        [JsonPropertyName("Gender")]
        public GenderColour Gender { get; set; }
        
        [JsonPropertyName("Pitch")]
        public PitchColour Pitch { get; set; }
        
        [JsonPropertyName("Reverb")]
        public ReverbColour Reverb { get; set; }
    }
    
    public class EchoColour : ThreeColour {}
    public class GenderColour : ThreeColour {}
    public class PitchColour : ThreeColour {}
    public class ReverbColour : ThreeColour {}
}