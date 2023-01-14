using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons
{
    public class ButtonsLight
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
        public Fader1Mute Fader1Mute { get; set; }
        
        [JsonPropertyName("Fader2Mute")]
        public Fader2Mute Fader2Mute { get; set; }
        
        [JsonPropertyName("Fader3Mute")]
        public Fader3Mute Fader3Mute { get; set; }
        
        [JsonPropertyName("Fader4Mute")]
        public Fader4Mute Fader4Mute { get; set; }
    }
    
    public class Bleep : ButtonsLightBase { }
    public class Cough : ButtonsLightBase { }
    public class EffectFx : ButtonsLightBase { }
    public class EffectHardTune : ButtonsLightBase { }
    public class EffectMegaphone : ButtonsLightBase { }
    public class EffectRobot : ButtonsLightBase { }
    public class EffectSelect1 : ButtonsLightBase { }
    public class EffectSelect2 : ButtonsLightBase { }
    public class EffectSelect3 : ButtonsLightBase { }
    public class EffectSelect4 : ButtonsLightBase { }
    public class EffectSelect5 : ButtonsLightBase { }
    public class EffectSelect6 : ButtonsLightBase { }
    public class Fader1Mute : ButtonsLightBase { }
    public class Fader2Mute : ButtonsLightBase { }
    public class Fader3Mute : ButtonsLightBase { }
    public class Fader4Mute : ButtonsLightBase { }
    
    public class ButtonsLightBase
    {
        [JsonPropertyName("off_style")]
        public string OffStyle { get; set; }
        
        [JsonPropertyName("colours")]
        public TwoColour Colours { get; set; }
    }
}