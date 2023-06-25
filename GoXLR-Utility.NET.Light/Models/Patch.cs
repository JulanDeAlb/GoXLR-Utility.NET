using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response;

namespace GoXLR_Utility.NET.Light.Models
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

        public override string ToString()
        {
            return $"Op: {Op.ToString()} | Value: {Value} | Path: {Path}";
        }
    }
}