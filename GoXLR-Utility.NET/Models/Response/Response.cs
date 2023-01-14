using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.DaemonResponse
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
        
        public DataPayload Data { get; set; }
        public string SimpleData { get; set; }
    }
    
    public class DataPayload
    {
        [JsonPropertyName("Error")]
        public string Error { get; set; }

        [JsonPropertyName("HttpState")]
        public HttpSettings.HttpSettings HttpState { get; set; }

        [JsonPropertyName("Patch")]
        public Patch.Patch[] Patch { get; set; }

        [JsonPropertyName("Status")]
        public Models.Response.Status.Status Status { get; set; }
    }
}