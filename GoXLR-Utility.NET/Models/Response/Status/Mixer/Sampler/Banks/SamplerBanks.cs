using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks
{
    /// <summary>
    /// <seealso cref="SamplerBankEvents"/>
    /// </summary>
    public class SamplerBanks
    {
        [JsonPropertyName("A")]
        public SamplerBankA SamplerBankA { get; set; }
        
        [JsonPropertyName("B")]
        public SamplerBankB SamplerBankB { get; set; }
        
        [JsonPropertyName("C")]
        public SamplerBankC SamplerBankC { get; set; }
    }
    
    public class SamplerBankA : SamplerBankBase { }
    public class SamplerBankB : SamplerBankBase { }
    public class SamplerBankC : SamplerBankBase { }
    
    /// <summary>
    /// <seealso cref="SamplerBankBaseEvents"/>
    /// </summary>
    public class SamplerBankBase
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
    /// <seealso cref="SamplerBankBaseButtonEvents"/>
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