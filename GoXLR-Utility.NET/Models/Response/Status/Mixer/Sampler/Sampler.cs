using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler
{
    public class Sampler
    {
        [JsonPropertyName("banks")]
        public Banks.Banks Banks { get; set; }
    }
}