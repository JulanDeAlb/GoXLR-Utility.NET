using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current
{
    public class Current
    {
        [JsonPropertyName("echo")]
        public EchoEffect Echo { get; set; }
        
        [JsonPropertyName("gender")]
        public GenderEffect Gender { get; set; }
        
        [JsonPropertyName("hard_tune")]
        public HardTuneEffect HardTune { get; set; }
        
        [JsonPropertyName("megaphone")]
        public MegaphoneEffect Megaphone { get; set; }
        
        [JsonPropertyName("pitch")]
        public PitchEffect Pitch { get; set; }
        
        [JsonPropertyName("reverb")]
        public ReverbEffect Reverb { get; set; }
        
        [JsonPropertyName("robot")]
        public RobotEffect Robot { get; set; }
    }
}