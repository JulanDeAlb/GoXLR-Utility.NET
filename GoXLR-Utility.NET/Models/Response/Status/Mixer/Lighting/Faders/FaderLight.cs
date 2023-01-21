using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders
{
    public class FaderLight
    {
        [JsonPropertyName("A")]
        public FaderA FaderA { get; set; }
        
        [JsonPropertyName("B")]
        public FaderB FaderB { get; set; }
        
        [JsonPropertyName("C")]
        public FaderC FaderC { get; set; }
        
        [JsonPropertyName("D")]
        public FaderD FaderD { get; set; }
    }
    
    public class FaderA : FaderLightBase { }
    public class FaderB : FaderLightBase { }
    public class FaderC : FaderLightBase { }
    public class FaderD : FaderLightBase { }
    
    public class FaderLightBase
    {
        [JsonPropertyName("colours")]
        public TwoColour Colour { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FaderDisplayStyle Style { get; set; }
    }
}