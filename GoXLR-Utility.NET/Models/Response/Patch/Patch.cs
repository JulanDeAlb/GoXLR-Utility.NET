using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace GoXLR_Utility.NET.Models.Response.Patch
{
    public class Patch
    {
        [JsonPropertyName("op")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OpPatchEnum Op { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("value")]
        public JsonNode Value { get; set; }
    }
}