using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response
{
    public class Response
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }
        
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
                    Data = value.Deserialize<DataPayload>(Utility.SerializerOptions);
                }
            }
        }
        
        public DataPayload Data { get; set; }
        public string SimpleData { get; set; }
    }
}