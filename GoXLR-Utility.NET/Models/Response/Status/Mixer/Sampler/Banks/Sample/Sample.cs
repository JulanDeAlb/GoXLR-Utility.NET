using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample
{
    /// <summary>
    /// <seealso cref="SampleEvents"/>
    /// </summary>
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