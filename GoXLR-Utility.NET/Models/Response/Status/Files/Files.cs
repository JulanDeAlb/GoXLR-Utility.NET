using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Files;

namespace GoXLR_Utility.NET.Models.Response.Status.Files
{
    //Path: files/...
    
    /// <summary>
    /// <seealso cref="FileEvents"/>
    /// </summary>
    public class Files
    {
        [JsonPropertyName("icons")]
        public List<string> Icons { get; set; }
        
        [JsonPropertyName("mic_profiles")]
        public List<string> MicProfiles { get; set; }
        
        [JsonPropertyName("presets")]
        public List<string> Presets { get; set; }
        
        [JsonPropertyName("profiles")]
        public List<string> Profiles { get; set; }
        
        [JsonPropertyName("samples")]
        public Dictionary<string, string> Samples { get; set; }
    }
}