using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini
{
    public class MiniEqualiser
    {
        [JsonPropertyName("gain")]
        public MiniGain Gain { get; set; }
        
        [JsonPropertyName("frequency")]
        public MiniFrequency Frequency { get; set; }
    }
}