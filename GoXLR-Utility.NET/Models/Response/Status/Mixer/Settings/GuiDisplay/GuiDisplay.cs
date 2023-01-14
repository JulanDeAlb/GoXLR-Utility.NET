using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings.GuiDisplay
{
    /// <summary>
    /// <seealso cref="GuiDisplayEvents"/>
    /// </summary>
    public class GuiDisplay
    {
        [JsonPropertyName("compressor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Compressor { get; set; }
        
        [JsonPropertyName("equaliser")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Equaliser { get; set; }
        
        [JsonPropertyName("equaliser_fine")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum EqualiserFine { get; set; }
        
        [JsonPropertyName("gate")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Gate { get; set; }
    }
}