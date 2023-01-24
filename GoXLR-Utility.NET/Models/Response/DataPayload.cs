using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response
{
    public class DataPayload
    {
        [JsonPropertyName("Error")]
        public string Error{ get; internal set; }

        [JsonPropertyName("HttpState")]
        public HttpSettings.HttpSettings HttpState{ get; internal set; }

        [JsonPropertyName("Patch")]
        public Patch.Patch[] Patch { get; set; }

        [JsonPropertyName("Status")]
        public Status.Status Status { get; internal set; }
    }
}