using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels
{
    //Path: mixer/SERIAL-NUMBER/levels/...
    
    /// <summary>
    /// <seealso cref="LevelEvents"/>
    /// </summary>
    public class Levels
    {
        [JsonPropertyName("bleep")]
        public sbyte Bleep { get; set; }
        
        [JsonPropertyName("deess")]
        public sbyte DeEsser { get; set; }
        
        [JsonPropertyName("volumes")]
        public Volume Volumes { get; set; }
    }
}