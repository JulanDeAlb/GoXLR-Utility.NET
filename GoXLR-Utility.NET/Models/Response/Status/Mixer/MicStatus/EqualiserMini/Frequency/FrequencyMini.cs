using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    /// <summary>
    /// <seealso cref="EqualiserMiniFrequencyEvents"/>
    /// </summary>
    public class FrequencyMini
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