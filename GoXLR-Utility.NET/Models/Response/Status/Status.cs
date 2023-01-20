using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.Models.Response.Status
{
    public class Status
    {
        [JsonPropertyName("config")]
        public Config.Config Config { get; set; }

        [JsonPropertyName("files")]
        public Files.Files Files { get; set; }
        
        [JsonPropertyName("mixers")]
        public Dictionary<string, Device> Mixers { get; set; }
        
        [JsonPropertyName("paths")]
        public Paths.Paths Paths { get; set; }
    }
}