using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Hardware.UsbDevice
{
    public class UsbDevice
    {
        [JsonPropertyName("address")]
        public int Address { get; set; }

        [JsonPropertyName("bus_number")]
        public int BusNumber { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("manufacturer_name")]
        public string ManufacturerName { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("version")]
        public List<int> Version { get; set; }
    }
}