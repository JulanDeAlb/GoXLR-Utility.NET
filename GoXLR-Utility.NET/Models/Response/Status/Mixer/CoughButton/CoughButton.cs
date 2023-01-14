using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.CoughButton;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.CoughButton
{
    //Path: mixer/SERIAL-NUMBER/cough_button/...
    
    /// <summary>
    /// <seealso cref="CoughButtonEvents"/>
    /// </summary>
    public class CoughButton
    {
        [JsonPropertyName("is_toggle")]
        public bool IsToggle { get; set; }
        
        [JsonPropertyName("mute_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteFunction MuteFunction { get; set; }
        
        [JsonPropertyName("state")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteState MuteState { get; set; }
    }
}