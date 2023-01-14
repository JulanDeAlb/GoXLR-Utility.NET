using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class ReverbEffect
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("decay")]
        public int Decay { get; set; }
        
        [JsonPropertyName("diffuse")]
        public int Diffuse { get; set; }
        
        [JsonPropertyName("early_level")]
        public int EarlyLevel { get; set; }
        
        [JsonPropertyName("hi_colour")]
        public int HiColour { get; set; }
        
        [JsonPropertyName("hi_factor")]
        public int HiFactor { get; set; }
        
        [JsonPropertyName("lo_colour")]
        public int LoColour { get; set; }
        
        [JsonPropertyName("mod_depth")]
        public int ModDepth { get; set; }
        
        [JsonPropertyName("mod_speed")]
        public int ModSpeed { get; set; }
        
        [JsonPropertyName("pre_delay")]
        public int PreDelay { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReverbStyle Style { get; set; }
        
        [JsonPropertyName("tail_level")]
        public int TailLevel { get; set; }
    }
}