namespace GoXLR_Utility.NET.Enums.Response.Status.Mixer.ButtonDown
{
    public enum ButtonEnum
    {
        //These are on the GoXLR Mini
        Bleep,
        Cough,
        
        Fader1Mute,
        Fader2Mute,
        Fader3Mute,
        Fader4Mute,

        //These are only on the Full, will be ignored on the Mini
        EffectSelect1,
        EffectSelect2,
        EffectSelect3,
        EffectSelect4,
        EffectSelect5,
        EffectSelect6,
        
        EffectMegaphone,
        EffectRobot,
        EffectHardTune,
        EffectFx,
        
        SamplerSelectA,
        SamplerSelectB,
        SamplerSelectC,
        
        SamplerBottomLeft,
        SamplerBottomRight,
        SamplerTopLeft,
        SamplerTopRight
    }
}