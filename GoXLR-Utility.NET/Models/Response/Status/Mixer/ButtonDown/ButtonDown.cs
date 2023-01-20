using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.ButtonDown;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.ButtonDown
{
    //Path: mixer/SERIAL-NUMBER/button_down/...
    
    /// <summary>
    /// <seealso cref="ButtonDownEvents"/>
    /// </summary>
    public class ButtonDown
    {
        [JsonPropertyName("Bleep")]
        public bool Bleep { get; set; }

        [JsonPropertyName("Cough")]
        public bool Cough { get; set; }

        [JsonPropertyName("EffectFx")]
        public bool EffectFx { get; set; }
        
        [JsonPropertyName("EffectHardTune")]
        public bool EffectHardTune { get; set; }
        
        [JsonPropertyName("EffectMegaphone")]
        public bool EffectMegaphone { get; set; }
        
        [JsonPropertyName("EffectRobot")]
        public bool EffectRobot { get; set; }

        [JsonPropertyName("EffectSelect1")]
        public bool EffectSelect1 { get; set; }
        
        [JsonPropertyName("EffectSelect2")]
        public bool EffectSelect2 { get; set; }
        
        [JsonPropertyName("EffectSelect3")]
        public bool EffectSelect3 { get; set; }
        
        [JsonPropertyName("EffectSelect4")]
        public bool EffectSelect4 { get; set; }
        
        [JsonPropertyName("EffectSelect5")]
        public bool EffectSelect5 { get; set; }
        
        [JsonPropertyName("EffectSelect6")]
        public bool EffectSelect6 { get; set; }
        
        [JsonPropertyName("Fader1Mute")]
        public bool Fader1Mute { get; set; }
        
        [JsonPropertyName("Fader2Mute")]
        public bool Fader2Mute { get; set; }
        
        [JsonPropertyName("Fader3Mute")]
        public bool Fader3Mute { get; set; }
        
        [JsonPropertyName("Fader4Mute")]
        public bool Fader4Mute { get; set; }

        [JsonPropertyName("SamplerClear")]
        public bool SamplerClear { get; set; }

        [JsonPropertyName("SamplerSelectA")]
        public bool SamplerSelectA { get; set; }
        
        [JsonPropertyName("SamplerSelectB")]
        public bool SamplerSelectB { get; set; }
        
        [JsonPropertyName("SamplerSelectC")]
        public bool SamplerSelectC { get; set; }
        
        [JsonPropertyName("SamplerBottomLeft")]
        public bool SamplerBottomLeft { get; set; }
        
        [JsonPropertyName("SamplerBottomRight")]
        public bool SamplerBottomRight { get; set; }
        
        [JsonPropertyName("SamplerTopLeft")]
        public bool SamplerTopLeft { get; set; }
        
        [JsonPropertyName("SamplerTopRight")]
        public bool SamplerTopRight { get; set; }
    }
}