using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    public class MiniFrequency
    {
        [JsonPropertyName("Equalizer90Hz")]
        public double Equalizer90Hz { get; set; }
        
        [JsonPropertyName("Equalizer250Hz")]
        public double Equalizer250Hz { get; set; }
        
        [JsonPropertyName("Equalizer500Hz")]
        public double Equalizer500Hz { get; set; }
        
        [JsonPropertyName("Equalizer1KHz")]
        public double Equalizer1KHz { get; set; }
        
        [JsonPropertyName("Equalizer3KHz")]
        public double Equalizer3KHz { get; set; }
        
        [JsonPropertyName("Equalizer8KHz")]
        public double Equalizer8KHz { get; set; }
    }
}