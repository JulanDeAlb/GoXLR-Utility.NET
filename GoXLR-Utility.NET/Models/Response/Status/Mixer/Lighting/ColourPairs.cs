using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting
{
    public class TwoColour
    {
        [JsonPropertyName("colour_one")]
        public string ColourOne { get; set; }
        
        [JsonPropertyName("colour_two")]
        public string ColourTwo { get; set; }
    }

    public class ThreeColour
    {
        [JsonPropertyName("colour_one")]
        public string ColourOne { get; set; }
        
        [JsonPropertyName("colour_two")]
        public string ColourTwo { get; set; }
        
        [JsonPropertyName("colour_three")]
        public string ColourThree { get; set; }
    }
    
    public class OneColour
    {
        [JsonPropertyName("colour_one")]
        public string ColourOne { get; set; }
    }
}