using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class Sample
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("start_pct")]
        public double StartPct { get; set; }
        
        [JsonPropertyName("stop_pct")]
        public double StopPct { get; set; }
    }
}