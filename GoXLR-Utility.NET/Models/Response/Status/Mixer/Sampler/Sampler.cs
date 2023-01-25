using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler
{
    public class Sampler
    {
        [JsonPropertyName("banks")]
        public Banks.SamplerBanks SamplerBanks { get; set; }
    }
}