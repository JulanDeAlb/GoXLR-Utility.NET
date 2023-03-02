using System.Text.Json.Serialization;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace GoXLR_Utility.NET.Models.Response
{
    public class DataPayload
    {
        [JsonPropertyName("Error")]
        public string? Error{ get; set; }

        [JsonPropertyName("HttpState")]
        public HttpSettings.HttpSettings? HttpState{ get; set; }

        [JsonPropertyName("Patch")]
        public Patch.Patch[]? Patch { get; set; }

        [JsonPropertyName("Status")]
        public Status.Status? Status { get; set; }
    }
}