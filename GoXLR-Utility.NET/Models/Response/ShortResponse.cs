using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response
{
    public class ShortResponse
    {
        [JsonPropertyName("Status")]
        public SimpleStatus Status { get; set; }
    }

    public class SimpleStatus
    {
        [JsonPropertyName("config")]
        public SimpleConfig Config { get; set; }
    }

    public class SimpleConfig
    {
        [JsonPropertyName("http_settings")]
        public HttpSettings.HttpSettings HttpSettings { get; set; }
    }
}