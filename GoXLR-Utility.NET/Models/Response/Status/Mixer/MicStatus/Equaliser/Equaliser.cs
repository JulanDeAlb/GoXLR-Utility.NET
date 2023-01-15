using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser
{
    
    /// <summary>
    /// <seealso cref="EqualiserEvents"/>
    /// </summary>
    public class Equaliser
    {
        [JsonPropertyName("gain")]
        public Gain.Gain Gain { get; set; }
        
        [JsonPropertyName("frequency")]
        public Frequency.Frequency Frequency { get; set; }
    }
}