using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class RobotEffect
    {
        [JsonPropertyName("dry_mix")]
        public int DryMix { get; set; }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }
        
        [JsonPropertyName("high_freq")]
        public int HighFreq { get; set; }
        
        [JsonPropertyName("high_gain")]
        public int HighGain { get; set; }
        
        [JsonPropertyName("high_width")]
        public int HighWidth { get; set; }
        
        [JsonPropertyName("low_freq")]
        public int LowFreq { get; set; }
        
        [JsonPropertyName("low_gain")]
        public int LowGain { get; set; }
        
        [JsonPropertyName("low_width")]
        public int LowWidth { get; set; }
        
        [JsonPropertyName("mid_freq")]
        public int MidFreq { get; set; }
        
        [JsonPropertyName("mid_gain")]
        public int MidGain { get; set; }
        
        [JsonPropertyName("mid_width")]
        public int MidWidth { get; set; }
        
        [JsonPropertyName("pulse_width")]
        public int PulseWidth { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RobotStyle Style { get; set; }
        
        [JsonPropertyName("threshold")]
        public int Threshold { get; set; }

        [JsonPropertyName("waveform")]
        public int WaveFrom { get; set; }
    }
}