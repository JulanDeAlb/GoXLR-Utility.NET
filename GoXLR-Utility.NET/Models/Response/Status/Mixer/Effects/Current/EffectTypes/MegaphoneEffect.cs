using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class MegaphoneEffect
    { 
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }
        
        [JsonPropertyName("post_gain")]
        public int PostGain { get; set; }

        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MegaphoneStyle Style { get; set; }
    }
}