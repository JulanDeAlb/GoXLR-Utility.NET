namespace GoXLR_Utility.NET
{
    public enum ChannelNames { //!DONE
        Mic,
        Chat,
        Music,
        Game,
        Console,
        LineIn,
        LineOut,
        System,
        Sample,
        Headphones,
        MicMonitor,
    }

    public enum FaderNames //!DONE
    {
        A,
        B,
        C,
        D
    }

    public enum EncoderName
    {
        Echo,
        Gender,
        Pitch,
        Reverb
    }

    public enum InputDevice //!DONE
    {
        Microphone,
        Chat,
        Music,
        Game,
        Console,
        LineIn,
        System,
        Sampler
    }

    public enum OutputDevice //!DONE
    {
        Headphones,
        BroadcastMix,
        LineOut,
        ChatMic,
        Sampler
    }

    public enum FaderDisplayStyle //!DONE
    {
        Gradient,
        GradientMeter,
        Meter,
        TwoColour
    }

    public enum Button //!DONE
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

    public enum SimpleColourTargets
    {
        Global,
        Accent,
        Scribble1,
        Scribble2,
        Scribble3,
        Scribble4
    }

    public enum SamplerColourTargets
    {
        SamplerSelectA,
        SamplerSelectB,
        SamplerSelectC
    }

    public enum EncoderColourTargets
    {
        Reverb,
        Pitch,
        Echo,
        Gender
    }

    public enum ButtonColourGroups
    {
        FaderMute,
        EffectSelector,
        SampleBankSelector,
        SamplerButtons
    }
    
    public enum ButtonColourOffStyle {
        Dimmed,
        Colour2,
        DimmedColour2,
    }

    public enum MuteFunction //!DONE
    {
        All,
        ToStream,
        ToVoiceChat,
        ToPhones,
        ToLineOut
    }

    public enum MicrophoneTypes //!DONE
    {
        Dynamic,
        Condenser,
        Jack
    }

    public enum EffectBankPresetss //!DONE
    {
        Preset1,
        Preset2,
        Preset3,
        Preset4,
        Preset5,
        Preset6
    }

    public enum SampleBank //!DONE
    {
        A,
        B,
        C
    }

    public enum MiniEqFrequencies //!DONE
    {
        Equalizer31Hz,
        Equalizer63Hz,
        Equalizer125Hz,
        Equalizer250Hz,
        Equalizer500Hz,
        Equalizer1KHz,
        Equalizer2KHz,
        Equalizer4KHz,
        Equalizer8KHz,
        Equalizer16KHz,
    }

    public enum ReverbStyles //!DONE
    {
        Library,
        DarkBloom,
        MusicClub,
        RealPlate,
        Chapel,
        HockeyArena,
    }

    public enum EchoStyles //!DONE
    {
        Quarter,
        Eighth,
        Triplet,
        PingPong,
        ClassicSlap,
        MultiTap,
    }
    
    public enum PitchStyles { //!DONE
        Narrow,
        Wide,
    }
    
    public enum GenderStyles { //!DONE
        Narrow,
        Medium,
        Wide,
    }
    
    public enum MegaphoneStyles { //!DONE
        Megaphone,
        Radio,
        OnThePhone,
        Overdrive,
        BuzzCutt,
        Tweed,
    }
    
    public enum RobotStyles { //!DONE
        Robot1,
        Robot2,
        Robot3,
    }
    
    public enum RobotRanges { //!DONE
        Low,
        Medium,
        High,
    }
    
    public enum HardTuneStyles { //!DONE
        Natural,
        Medium,
        Hard,
    }
    
    public enum HardTuneSources { //!DONE
        All,
        Music,
        Game,
        LineIn,
        System,
    }
    
    public enum SampleButtons {  //!DONE
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
    }
    
    public enum SamplePlaybackModes { //!DONE
        PlayNext,
        PlayStop,
        PlayFade,
        StopOnRelease,
        FadeOnRelease,
        Loop,
    }
    
    public enum SamplePlayOrders {//!DONE
        Sequential,
        Random,
    }
    
    public enum DisplayModes { //!DONE
        Simple,
        Advanced,
    }
    
    public enum DisplayModeComponents {
        NoiseGate,
        Equaliser,
        Compressor,
        EqFineTune,
    }
    
    public enum MuteStates { //!DONE
        Unmuted,
        MutedToX,
        MutedToAll,
    }
    
    public enum CompressorRatio {
        Ratio1_0,
        Ratio1_1,
        Ratio1_2,
        Ratio1_4,
        Ratio1_6,
        Ratio1_8,
        Ratio2_0,
        Ratio2_5,
        Ratio3_2,
        Ratio4_0,
        Ratio5_6,
        Ratio8_0,
        Ratio16_0,
        Ratio32_0,
        Ratio64_0,
    }
    
    public enum GateTimes {
        Gate10ms,
        Gate20ms,
        Gate30ms,
        Gate40ms,
        Gate50ms,
        Gate60ms,
        Gate70ms,
        Gate80ms,
        Gate90ms,
        Gate100ms,
        Gate110ms,
        Gate120ms,
        Gate130ms,
        Gate140ms,
        Gate150ms,
        Gate160ms,
        Gate170ms,
        Gate180ms,
        Gate190ms,
        Gate200ms,
        Gate250ms,
        Gate300ms,
        Gate350ms,
        Gate400ms,
        Gate450ms,
        Gate500ms,
        Gate550ms,
        Gate600ms,
        Gate650ms,
        Gate700ms,
        Gate750ms,
        Gate800ms,
        Gate850ms,
        Gate900ms,
        Gate950ms,
        Gate1000ms,
        Gate1100ms,
        Gate1200ms,
        Gate1300ms,
        Gate1400ms,
        Gate1500ms,
        Gate1600ms,
        Gate1700ms,
        Gate1800ms,
        Gate1900ms,
        Gate2000ms,
    }
    
    public enum CompressorAttackTime {
        // Note: 0ms is technically 0.001ms
        Comp0ms,
        Comp2ms,
        Comp3ms,
        Comp4ms,
        Comp5ms,
        Comp6ms,
        Comp7ms,
        Comp8ms,
        Comp9ms,
        Comp10ms,
        Comp12ms,
        Comp14ms,
        Comp16ms,
        Comp18ms,
        Comp20ms,
        Comp23ms,
        Comp26ms,
        Comp30ms,
        Comp35ms,
        Comp40ms,
    }
    
    public enum CompressorReleaseTime {
        // Note: 0 is technically 15 :)
        Comp0ms,
        Comp15ms,
        Comp25ms,
        Comp35ms,
        Comp45ms,
        Comp55ms,
        Comp65ms,
        Comp75ms,
        Comp85ms,
        Comp100ms,
        Comp115ms,
        Comp140ms,
        Comp170ms,
        Comp230ms,
        Comp340ms,
        Comp680ms,
        Comp1000ms,
        Comp1500ms,
        Comp2000ms,
        Comp3000ms,
    }

}