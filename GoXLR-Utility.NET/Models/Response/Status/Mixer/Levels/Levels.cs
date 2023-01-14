using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels
{
    //Path: mixer/SERIAL-NUMBER/levels/...
    public class Levels
    {
        [JsonPropertyName("bleep")]
        public sbyte Bleep { get; set; }
        
        [JsonPropertyName("deess")] //TODO DeEsser needs event in Mic Settings i guess
        public sbyte DeEsser { get; set; }
        
        [JsonPropertyName("volumes")]
        public Volume Volumes { get; set; }
    }
}