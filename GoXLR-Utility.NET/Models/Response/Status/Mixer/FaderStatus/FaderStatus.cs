using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus
{
    /// <summary>
    /// <seealso cref="FaderStatusEvents"/>
    /// </summary>
    public class FaderStatus
    {
        [JsonPropertyName("A")]
        public FaderA FaderA { get; set; }
        
        [JsonPropertyName("B")]
        public FaderB FaderB { get; set; }
        
        [JsonPropertyName("C")]
        public FaderC FaderC { get; set; }
        
        [JsonPropertyName("D")]
        public FaderD FaderD { get; set; }
    }
    
    public class FaderA : FaderBase {}
    public class FaderB : FaderBase {}
    public class FaderC : FaderBase {}
    public class FaderD : FaderBase {}
    
    /// <summary>
    /// <seealso cref="FaderBaseEvent"/>
    /// </summary>
    public class FaderBase
    {
        [JsonPropertyName("channel")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FaderChannelEnum Channel { get; set; }
        
        [JsonPropertyName("mute_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteFunction MuteType { get; set; }
        
        [JsonPropertyName("mute_state")]
        public MuteState MuteState { get; set; }
        
        [JsonPropertyName("scribble")]
        public Scribble.FaderScribble Scribble { get; set; }
    }
}