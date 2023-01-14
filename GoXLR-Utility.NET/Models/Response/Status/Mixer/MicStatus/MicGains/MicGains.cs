using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains
{
    public class MicGains
    {
        [JsonPropertyName("Condenser")]
        public int Condenser { get; set; }
        
        [JsonPropertyName("Dynamic")]
        public int Dynamic { get; set; }
        
        [JsonPropertyName("Jack")]
        public int Jack { get; set; }
    }
}