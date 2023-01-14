using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler
{
    public class SamplerLight
    {
        [JsonPropertyName("SamplerSelectA")]
        public SamplerA SamplerA { get; set; }
        
        [JsonPropertyName("SamplerSelectB")]
        public SamplerB SamplerB { get; set; }
        
        [JsonPropertyName("SamplerSelectC")]
        public SamplerC SamplerC { get; set; }
    }
    
    public class SamplerA : SamplerLightBase { } 
    public class SamplerB : SamplerLightBase { } 
    public class SamplerC : SamplerLightBase { } 
    
    public class SamplerLightBase
    {
        [JsonPropertyName("off_style")]
        public string OffStyle { get; set; }
        
        [JsonPropertyName("colours")]
        public ThreeColour Colour { get; set; }
    }
}