using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class PitchEffect
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("character")]
        public int Character { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PitchStyle Style { get; set; }
    }
}