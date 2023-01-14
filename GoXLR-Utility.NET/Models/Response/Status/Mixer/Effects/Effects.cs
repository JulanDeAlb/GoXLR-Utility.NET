using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects
{
    public class Effects
    {
        [JsonPropertyName("active_preset")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EffectBankPresets ActivePreset { get; set; }
        
        [JsonPropertyName("current")]
        public Current.Current Current { get; set; }

        [JsonPropertyName("preset_names")]
        public PresetNames.PresetNames PresetNames { get; set; }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }
    }
}