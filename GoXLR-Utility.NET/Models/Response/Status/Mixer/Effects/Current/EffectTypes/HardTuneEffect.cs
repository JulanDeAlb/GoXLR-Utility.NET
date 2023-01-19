using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class HardTuneEffect
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }
        
        [JsonPropertyName("rate")]
        public int Rate { get; set; }

        [JsonPropertyName("source")]
        public HardTuneSource Source { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public HardTuneStyle Style { get; set; }
        
        [JsonPropertyName("window")]
        public int Window { get; set; }
    }
}