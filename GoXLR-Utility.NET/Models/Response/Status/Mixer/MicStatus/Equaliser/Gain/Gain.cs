using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    public class Gain
    {
        [JsonPropertyName("Equalizer31Hz")]
        public int Equalizer31Hz { get; set; }
        
        [JsonPropertyName("Equalizer63Hz")]
        public int Equalizer63Hz { get; set; }
        
        [JsonPropertyName("Equalizer125Hz")]
        public int Equalizer125Hz { get; set; }
        
        [JsonPropertyName("Equalizer250Hz")]
        public int Equalizer250Hz { get; set; }
        
        [JsonPropertyName("Equalizer500Hz")]
        public int Equalizer500Hz { get; set; }
        
        [JsonPropertyName("Equalizer1KHz")]
        public int Equalizer1KHz { get; set; }
        
        [JsonPropertyName("Equalizer2KHz")]
        public int Equalizer2KHz { get; set; }
        
        [JsonPropertyName("Equalizer4KHz")]
        public int Equalizer4KHz { get; set; }
        
        [JsonPropertyName("Equalizer8KHz")]
        public int Equalizer8KHz { get; set; }
        
        [JsonPropertyName("Equalizer16KHz")]
        public int Equalizer16KHz { get; set; }
    }
}