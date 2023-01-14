using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain
{
    public class MiniGain
    {
        [JsonPropertyName("Equalizer90Hz")]
        public int Equalizer90Hz { get; set; }
        
        [JsonPropertyName("Equalizer250Hz")]
        public int Equalizer250Hz { get; set; }
        
        [JsonPropertyName("Equalizer500Hz")]
        public int Equalizer500Hz { get; set; }
        
        [JsonPropertyName("Equalizer1KHz")]
        public int Equalizer1KHz { get; set; }
        
        [JsonPropertyName("Equalizer3KHz")]
        public int Equalizer3KHz { get; set; }
        
        [JsonPropertyName("Equalizer8KHz")]
        public int Equalizer8KHz { get; set; }
    }
}