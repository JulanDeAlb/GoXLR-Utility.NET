using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble
{
    /// <summary>
    /// <seealso cref="FaderScribbleEvents"/>
    /// </summary>
    public class FaderScribble
    { 
        [JsonPropertyName("bottom_text")]
        public string BottomText { get; set; }
        
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
        
        [JsonPropertyName("inverted")]
        public bool Inverted { get; set; }
        
        [JsonPropertyName("left_text")]
        public string LeftText { get; set; }
    }
}