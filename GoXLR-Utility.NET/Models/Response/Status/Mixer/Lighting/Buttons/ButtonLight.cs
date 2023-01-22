using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons
{
    public class ButtonLight
    {
        [JsonPropertyName("Bleep")]
        public Bleep Bleep { get; set; }
        
        [JsonPropertyName("Cough")]
        public Cough Cough { get; set; }
        
        [JsonPropertyName("EffectFx")]
        public EffectFx EffectFx { get; set; }
        
        [JsonPropertyName("EffectHardTune")]
        public EffectHardTune EffectHardTune { get; set; }
        
        [JsonPropertyName("EffectMegaphone")]
        public EffectMegaphone EffectMegaphone { get; set; }
        
        [JsonPropertyName("EffectRobot")]
        public EffectRobot EffectRobot { get; set; }
        
        [JsonPropertyName("EffectSelect1")]
        public EffectSelect1 EffectSelect1 { get; set; }
        
        [JsonPropertyName("EffectSelect2")]
        public EffectSelect2 EffectSelect2 { get; set; }
        
        [JsonPropertyName("EffectSelect3")]
        public EffectSelect3 EffectSelect3 { get; set; }
        
        [JsonPropertyName("EffectSelect4")]
        public EffectSelect4 EffectSelect4 { get; set; }
        
        [JsonPropertyName("EffectSelect5")]
        public EffectSelect5 EffectSelect5 { get; set; }
        
        [JsonPropertyName("EffectSelect6")]
        public EffectSelect6 EffectSelect6 { get; set; }

        [JsonPropertyName("Fader1Mute")]
        public FaderAMute FaderAMute { get; set; }
        
        [JsonPropertyName("Fader2Mute")]
        public FaderBMute FaderBMute { get; set; }
        
        [JsonPropertyName("Fader3Mute")]
        public FaderCMute FaderCMute { get; set; }
        
        [JsonPropertyName("Fader4Mute")]
        public FaderDMute FaderDMute { get; set; }
    }
    
    public class Bleep : ButtonLightBase { }
    public class Cough : ButtonLightBase { }
    public class EffectFx : ButtonLightBase { }
    public class EffectHardTune : ButtonLightBase { }
    public class EffectMegaphone : ButtonLightBase { }
    public class EffectRobot : ButtonLightBase { }
    public class EffectSelect1 : ButtonLightBase { }
    public class EffectSelect2 : ButtonLightBase { }
    public class EffectSelect3 : ButtonLightBase { }
    public class EffectSelect4 : ButtonLightBase { }
    public class EffectSelect5 : ButtonLightBase { }
    public class EffectSelect6 : ButtonLightBase { }
    public class FaderAMute : ButtonLightBase { }
    public class FaderBMute : ButtonLightBase { }
    public class FaderCMute : ButtonLightBase { }
    public class FaderDMute : ButtonLightBase { }
    
    public class ButtonLightBase
    {
        [JsonPropertyName("colours")]
        public TwoColour Colour { get; set; }
        
        [JsonPropertyName("off_style")]
        public string OffStyle { get; set; }
    }
}