using System;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Hardware
{
    //Path: mixer/SERIAL-NUMBER/hardware/...
    public class Hardware
    {
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }
        
        [JsonPropertyName("manufactured_date")]
        public DateTimeOffset ManufacturedDate { get; set; }
        
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }
        
        [JsonPropertyName("usb_device")]
        public UsbDevice.UsbDevice UsbDevice { get; set; }
        
        [JsonPropertyName("versions")]
        public Versions.Versions Versions { get; set; }
    }
}