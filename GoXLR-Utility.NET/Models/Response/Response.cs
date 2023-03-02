using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response
{
    public class Response
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        
        [JsonPropertyName("data")]
        public JsonElement JsonElement {
            set
            {
                if (value.ValueKind == JsonValueKind.String)
                {
                    SimpleData = value.GetString();
                }
                else
                {
                    Data = value.Deserialize<DataPayload>(new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } });
                }
            }
        }
        
        public DataPayload? Data { get; set; }
        public string? SimpleData { get; set; }
    }
}