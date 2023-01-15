using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus
{
    /// <summary>
    /// <seealso cref="MicStatusEvents"/>
    /// </summary>
    public class MicStatus
    {
        [JsonPropertyName("compressor")]
        public Compressor.Compressor Compressor { get; set; }
        
        [JsonPropertyName("equaliser")]
        public Equaliser.Equaliser Equaliser { get; set; }
        
        [JsonPropertyName("equaliser_mini")]
        public EqualiserMini.EqualiserMini EqualiserMini { get; set; }
        
        [JsonPropertyName("mic_gains")]
        public MicGains.MicGains MicGains { get; set; }
        
        [JsonPropertyName("noise_gate")]
        public NoiseGate.NoiseGate NoiseGate { get; set; }
        
        [JsonPropertyName("mic_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MicrophoneType MicType { get; set; }
    }
}