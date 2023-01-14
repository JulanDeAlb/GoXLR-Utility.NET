using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks
{
    public class Banks
    {
        [JsonPropertyName("A")]
        public SampleBankA SamplerBankA { get; set; }
        
        [JsonPropertyName("B")]
        public SamplerBankB SamplerBankB { get; set; }
        
        [JsonPropertyName("C")]
        public SamplerBankC SamplerBankC { get; set; }
        
        [JsonPropertyName("D")]
        public SamplerBankD SamplerBankD { get; set; }
    }
    
    public class SampleBankA : BanksBase { }
    public class SamplerBankB : BanksBase { }
    public class SamplerBankC : BanksBase { }
    public class SamplerBankD : BanksBase { }
    
    public class BanksBase
    { 
        [JsonPropertyName("BottomLeft")]
        public BottomLeftBank BottomLeft { get; set; }
        
        [JsonPropertyName("BottomRight")]
        public BottomRightBank BottomRight { get; set; }
        
        [JsonPropertyName("TopLeft")]
        public TopLeftBank TopLeft { get; set; }
        
        [JsonPropertyName("TopRight")]
        public TopRightBank TopRight { get; set; }
    }
    
    public class BottomLeftBank : BankBaseButton { }
    public class BottomRightBank : BankBaseButton { }
    public class TopLeftBank : BankBaseButton { }
    public class TopRightBank : BankBaseButton { }
    
    /// <summary>
    /// <seealso cref="BankEvents"/>
    /// </summary>
    public class BankBaseButton
    {
        [JsonPropertyName("function")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SamplePlaybackMode Function { get; set; }
        
        [JsonPropertyName("is_playing")]
        public bool IsPlaying { get; set; }
        
        [JsonPropertyName("order")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SamplePlayOrder Order { get; set; }
        
        [JsonPropertyName("samples")]
        public List<Sample.Sample> Samples { get; set; }
    }
}