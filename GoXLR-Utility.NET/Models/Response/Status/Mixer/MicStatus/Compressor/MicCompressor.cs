using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor
{
    public class MicCompressor
    { 
        [JsonPropertyName("attack")]
        public int Attack { get; set; }
        
        [JsonPropertyName("makeup_gain")]
        public int MakeUpGain { get; set; }

        [JsonPropertyName("ratio")]
        public int Ratio { get; set; }
        
        [JsonPropertyName("release")]
        public int Release { get; set; }
        
        [JsonPropertyName("threshold")]
        public int Threshold { get; set; }
    }
}