using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response;

namespace GoXLR_Utility.NET.Core.Models
{
    public class Patch
    {
        private JsonNode _node;
        
        [JsonPropertyName("op")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OpPatchEnum Op { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; } 
        
        /// <summary>
        /// This Value is a JsonNode
        /// </summary>
        [JsonPropertyName("value")]
        public JsonNode JsonNode
        {
            get => _node;
            set
            {
                _node = value;
                Value = _node.Deserialize<JsonElement>();
                HasValue = Value.ValueKind != JsonValueKind.Undefined;
            }
        }

        public JsonElement Value { get; private set; }

        public bool HasValue { get; private set; }

        public override string ToString()
        {
            return $"Op: {Op.ToString()} | Path: {Path} | Value: {Value} | HasValue: {HasValue}";
        }
    }
}