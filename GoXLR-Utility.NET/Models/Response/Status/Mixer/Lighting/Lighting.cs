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
        public ButtonLight Button { get; set; } //TODO
        
        [JsonPropertyName("encoders")]
        public EncoderLight Encoder { get; set; } //TODO
        
        [JsonPropertyName("faders")]
        public FaderLight Fader { get; set; } //TODO
        
        [JsonPropertyName("sampler")]
        public SamplerLight Sampler { get; set; } //TODO
        
        [JsonPropertyName("simple")]
        public SimpleLight Simple { get; set; }
    }
}