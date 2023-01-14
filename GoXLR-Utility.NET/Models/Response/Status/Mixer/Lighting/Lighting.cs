using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting
{
    public class Lighting
    {
        [JsonPropertyName("buttons")]
        public ButtonsLight Buttons { get; set; }
        
        [JsonPropertyName("encoders")]
        public EncodersLight Encoders { get; set; }
        
        [JsonPropertyName("faders")]
        public FadersLight Faders { get; set; }
        
        [JsonPropertyName("sampler")]
        public SamplerLight Sampler { get; set; }
        
        [JsonPropertyName("simple")]
        public SimpleLight Simple { get; set; }
    }
}