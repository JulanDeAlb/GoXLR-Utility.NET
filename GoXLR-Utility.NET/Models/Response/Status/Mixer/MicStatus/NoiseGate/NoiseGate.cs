using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate
{
    /// <summary>
    /// <seealso cref="NoiseGateEvents"/>
    /// </summary>
    public class NoiseGate
    {
        [JsonPropertyName("attack")]
        public int Attack { get; set; }
        
        [JsonPropertyName("attenuation")]
        public int Attenuation { get; set; }
        
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
        
        [JsonPropertyName("release")]
        public int Release { get; set; }
        
        [JsonPropertyName("threshold")]
        public int Threshold { get; set; }
    }
}