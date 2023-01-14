using System;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Hardware.UsbDeveice;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Hardware
{
    public class Hardware
    {
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }
        
        [JsonPropertyName("manufactured_date")]
        public DateTimeOffset ManufacturedDate { get; set; }
        
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }
        
        [JsonPropertyName("usb_device")]
        public UsbDevice UsbDevice { get; set; }
        
        [JsonPropertyName("versions")]
        public Versions.Versions Versions { get; set; }
    }
}