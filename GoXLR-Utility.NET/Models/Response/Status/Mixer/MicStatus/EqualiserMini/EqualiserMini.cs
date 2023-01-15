using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini
{
    /// <summary>
    /// <seealso cref="EqualiserMiniEvents"/>
    /// </summary>
    public class EqualiserMini
    {
        [JsonPropertyName("gain")]
        public GainMini Gain { get; set; }
        
        [JsonPropertyName("frequency")]
        public FrequencyMini Frequency { get; set; }
    }
}