using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser
{
    public class Equaliser
    {
        [JsonPropertyName("gain")]
        public Gain.Gain Gain { get; set; }
        
        [JsonPropertyName("frequency")]
        public Frequency.Frequency Frequency { get; set; }
    }
}