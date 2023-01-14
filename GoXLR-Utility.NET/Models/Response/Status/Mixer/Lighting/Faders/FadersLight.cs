using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders
{
    public class FadersLight
    {
        [JsonPropertyName("A")]
        public FadersA FadersA { get; set; }
        
        [JsonPropertyName("B")]
        public FadersB FadersB { get; set; }
        
        [JsonPropertyName("C")]
        public FadersC FadersC { get; set; }
        
        [JsonPropertyName("D")]
        public FadersD FadersD { get; set; }
    }
    
    public class FadersA : FadersLightBase { }
    public class FadersB : FadersLightBase { }
    public class FadersC : FadersLightBase { }
    public class FadersD : FadersLightBase { }
    
    public class FadersLightBase
    {
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FaderDisplayStyle Style { get; set; }
        
        [JsonPropertyName("colours")]
        public TwoColour Colour { get; set; }
    }
}