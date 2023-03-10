using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Hardware.Versions
{
    public class Versions
    {
        [JsonPropertyName("dice")]
        public List<int> Dice { get; set; }

        [JsonPropertyName("firmware")]
        public List<int> Firmware { get; set; }

        [JsonPropertyName("fpga_count")]
        public int FpgaCount { get; set; }
    }
}