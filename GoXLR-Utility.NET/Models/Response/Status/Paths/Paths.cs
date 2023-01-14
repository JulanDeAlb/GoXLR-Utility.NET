using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Paths;

namespace GoXLR_Utility.NET.Models.Response.Status.Paths
{
    //Path: paths/...
    
    /// <summary>
    /// <seealso cref="PathEvents"/>
    /// </summary>
    public class Paths
    {
        [JsonPropertyName("icons_directory")]
        public string IconsDirectory { get; set; }
        
        [JsonPropertyName("mic_profile_directory")]
        public string MicProfileDirectory { get; set; }
        
        [JsonPropertyName("presets_directory")]
        public string PresetsDirectory { get; set; }
        
        [JsonPropertyName("profile_directory")]
        public string ProfileDirectory { get; set; }
        
        [JsonPropertyName("samples_directory")]
        public string SamplesDirectory { get; set; }
    }
}