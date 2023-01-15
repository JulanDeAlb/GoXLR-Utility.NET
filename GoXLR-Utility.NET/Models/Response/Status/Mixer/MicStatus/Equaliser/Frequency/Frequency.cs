using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser.Frequency;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency
{
    /// <summary>
    /// <seealso cref="EqualiserFrequencyEvents"/>
    /// </summary>
    public class Frequency
    {
        [JsonPropertyName("Equalizer31Hz")]
        public double Equalizer31Hz { get; set; }
        
        [JsonPropertyName("Equalizer63Hz")]
        public double Equalizer63Hz { get; set; }
        
        [JsonPropertyName("Equalizer125Hz")]
        public double Equalizer125Hz { get; set; }
        
        [JsonPropertyName("Equalizer250Hz")]
        public double Equalizer250Hz { get; set; }
        
        [JsonPropertyName("Equalizer500Hz")]
        public double Equalizer500Hz { get; set; }
        
        [JsonPropertyName("Equalizer1KHz")]
        public double Equalizer1KHz { get; set; }
        
        [JsonPropertyName("Equalizer2KHz")]
        public double Equalizer2KHz { get; set; }
        
        [JsonPropertyName("Equalizer4KHz")]
        public double Equalizer4KHz { get; set; }
        
        [JsonPropertyName("Equalizer8KHz")]
        public double Equalizer8KHz { get; set; }
        
        [JsonPropertyName("Equalizer16KHz")]
        public double Equalizer16KHz { get; set; }
    }
}