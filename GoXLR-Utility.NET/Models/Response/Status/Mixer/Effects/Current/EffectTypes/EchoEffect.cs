using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    public class EchoEffect
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("delay_left")]
        public int DelayLeft { get; set; }
        
        [JsonPropertyName("delay_right")]
        public int DelayRight { get; set; }
        
        [JsonPropertyName("feedback")]
        public int Feedback { get; set; }
        
        [JsonPropertyName("feedback_left")]
        public int FeedbackLeft { get; set; }
        
        [JsonPropertyName("feedback_right")]
        public int FeedbackRight { get; set; }
        
        [JsonPropertyName("feedback_xfb_r_to_l")]
        public int FeedbackXfbRtL { get; set; }
        
        [JsonPropertyName("feedback_xfb_l_to_r")]
        public int FeedbackXfbLtR { get; set; }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EchoStyle Style { get; set; }
        
        [JsonPropertyName("tempo")]
        public int Tempo { get; set; }
    }
}