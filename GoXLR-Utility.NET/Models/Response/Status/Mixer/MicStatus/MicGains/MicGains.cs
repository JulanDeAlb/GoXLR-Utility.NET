using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.MicGains;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains
{
    /// <summary>
    /// <seealso cref="MicGainEvents"/>
    /// </summary>
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