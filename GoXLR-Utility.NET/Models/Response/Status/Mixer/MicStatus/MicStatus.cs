using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus
{
    public class MicStatus
    {
        [JsonPropertyName("equaliser")]
        public Equaliser.Equaliser Equaliser { get; set; }
        
        [JsonPropertyName("equaliser_mini")]
        public MiniEqualiser EqualiserMini { get; set; }
        
        [JsonPropertyName("compressor")]
        public MicCompressor MicCompressor { get; set; }
        
        [JsonPropertyName("mic_gains")]
        public MicGains.MicGains MicGains { get; set; }
        
        [JsonPropertyName("noise_gate")]
        public MicNoiseGate MicNoiseGate { get; set; }
        
        [JsonPropertyName("mic_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MicrophoneType MicType { get; set; }
    }
}