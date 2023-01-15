namespace GoXLR_Utility.NET.ConsoleTests;

public class Program
{
    private static Utility _utility = new Utility();
    
    public static void Main(string[] args)
    {
        _utility.Connect();
        AllEvents();
        Console.ReadKey();
        Console.ReadKey();
    }

    public static void AllEvents()
    {
        #region ButtonDown
        
        _utility.Events.Device.ButtonDown.OnButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnButtonDown");
        
        _utility.Events.Device.ButtonDown.OnBleepButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnBleepButtonDown");
        _utility.Events.Device.ButtonDown.OnCoughButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnCoughButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectFxButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectFxButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectHardTuneButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectHardTuneButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectMegaphoneButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectMegaphoneButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectRobotButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectRobotButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect1ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect1ButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect2ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect2ButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect3ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect3ButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect4ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect4ButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect5ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect5ButtonDown");
        _utility.Events.Device.ButtonDown.OnEffectSelect6ButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnEffectSelect6ButtonDown");
        _utility.Events.Device.ButtonDown.OnFader1MuteButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnFader1MuteButtonDown");
        _utility.Events.Device.ButtonDown.OnFader2MuteButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnFader2MuteButtonDown");
        _utility.Events.Device.ButtonDown.OnFader3MuteButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnFader3MuteButtonDown");
        _utility.Events.Device.ButtonDown.OnFader4MuteButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnFader4MuteButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerSelectAButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerSelectAButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerSelectBButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerSelectBButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerSelectCButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerSelectCButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerBottomLeftButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerBottomLeftButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerBottomRightButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerBottomRightButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerTopLeftButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerTopLeftButtonDown");
        _utility.Events.Device.ButtonDown.OnSamplerTopRightButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerTopRightButtonDown");

        #endregion
        
        #region CoughButton

        _utility.Events.Device.CoughButton.OnCoughButtonChanged += (sender, args) => Console.WriteLine("Events.Device.CoughButton.OnCoughButtonChanged");
        
        _utility.Events.Device.CoughButton.OnIsToggledChanged += (sender, args) => Console.WriteLine("Events.Device.CoughButton.OnIsToggledChanged");
        _utility.Events.Device.CoughButton.OnMuteFunctionChanged += (sender, args) => Console.WriteLine("Events.Device.CoughButton.OnMuteFunctionChanged");
        _utility.Events.Device.CoughButton.OnMuteStateChanged += (sender, args) => Console.WriteLine("Events.Device.CoughButton.OnMuteStateChanged");

        #endregion
        
        #region Effects

        

        #endregion
        
        #region FaderStatus

        _utility.Events.Device.FaderStatus.OnFadersChanged += (sender, args) => Console.WriteLine("");

        #region FaderStatus.FaderA

        _utility.Events.Device.FaderStatus.FaderA.OnFaderSettingsChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.OnFaderSettingsChanged");
        
        _utility.Events.Device.FaderStatus.FaderA.OnChannelChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.OnChannelChanged");
        _utility.Events.Device.FaderStatus.FaderA.OnMuteTypeChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.OnMuteTypeChanged");
        _utility.Events.Device.FaderStatus.FaderA.OnMuteStateChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.OnMuteStateChanged");
        _utility.Events.Device.FaderStatus.FaderA.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.OnScribbleChanged");

        #region FaderStatus.FaderA.Scribble

        _utility.Events.Device.FaderStatus.FaderA.Scribble.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.Scribble.OnScribbleChanged");
        
        _utility.Events.Device.FaderStatus.FaderA.Scribble.OnBottomTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.Scribble.OnBottomTextChanged");
        _utility.Events.Device.FaderStatus.FaderA.Scribble.OnFileNameChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.Scribble.OnFileNameChanged");
        _utility.Events.Device.FaderStatus.FaderA.Scribble.OnInvertedChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.Scribble.OnInvertedChanged");
        _utility.Events.Device.FaderStatus.FaderA.Scribble.OnLeftTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderA.Scribble.OnLeftTextChanged");

        #endregion

        #endregion
        
        #region FaderStatus.FaderB

        _utility.Events.Device.FaderStatus.FaderB.OnFaderSettingsChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.OnFaderSettingsChanged");
        
        _utility.Events.Device.FaderStatus.FaderB.OnChannelChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.OnChannelChanged");
        _utility.Events.Device.FaderStatus.FaderB.OnMuteTypeChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.OnMuteTypeChanged");
        _utility.Events.Device.FaderStatus.FaderB.OnMuteStateChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.OnMuteStateChanged");
        _utility.Events.Device.FaderStatus.FaderB.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.OnScribbleChanged");

        #region FaderStatus.FaderB.Scribble

        _utility.Events.Device.FaderStatus.FaderB.Scribble.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.Scribble.OnScribbleChanged");
        
        _utility.Events.Device.FaderStatus.FaderB.Scribble.OnBottomTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.Scribble.OnBottomTextChanged");
        _utility.Events.Device.FaderStatus.FaderB.Scribble.OnFileNameChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.Scribble.OnFileNameChanged");
        _utility.Events.Device.FaderStatus.FaderB.Scribble.OnInvertedChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.Scribble.OnInvertedChanged");
        _utility.Events.Device.FaderStatus.FaderB.Scribble.OnLeftTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderB.Scribble.OnLeftTextChanged");

        #endregion

        #endregion
        
        #region FaderStatus.FaderC

        _utility.Events.Device.FaderStatus.FaderC.OnFaderSettingsChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.OnFaderSettingsChanged");
        
        _utility.Events.Device.FaderStatus.FaderC.OnChannelChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.OnChannelChanged");
        _utility.Events.Device.FaderStatus.FaderC.OnMuteTypeChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.OnMuteTypeChanged");
        _utility.Events.Device.FaderStatus.FaderC.OnMuteStateChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.OnMuteStateChanged");
        _utility.Events.Device.FaderStatus.FaderC.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.OnScribbleChanged");

        #region FaderStatus.FaderC.Scribble

        _utility.Events.Device.FaderStatus.FaderC.Scribble.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.Scribble.OnScribbleChanged");
        
        _utility.Events.Device.FaderStatus.FaderC.Scribble.OnBottomTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.Scribble.OnBottomTextChanged");
        _utility.Events.Device.FaderStatus.FaderC.Scribble.OnFileNameChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.Scribble.OnFileNameChanged");
        _utility.Events.Device.FaderStatus.FaderC.Scribble.OnInvertedChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.Scribble.OnInvertedChanged");
        _utility.Events.Device.FaderStatus.FaderC.Scribble.OnLeftTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderC.Scribble.OnLeftTextChanged");

        #endregion

        #endregion
        
        #region FaderStatus.FaderD

        _utility.Events.Device.FaderStatus.FaderD.OnFaderSettingsChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.OnFaderSettingsChanged");
        
        _utility.Events.Device.FaderStatus.FaderD.OnChannelChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.OnChannelChanged");
        _utility.Events.Device.FaderStatus.FaderD.OnMuteTypeChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.OnMuteTypeChanged");
        _utility.Events.Device.FaderStatus.FaderD.OnMuteStateChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.OnMuteStateChanged");
        _utility.Events.Device.FaderStatus.FaderD.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.OnScribbleChanged");

        #region FaderStatus.FaderD.Scribble

        _utility.Events.Device.FaderStatus.FaderD.Scribble.OnScribbleChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.Scribble.OnScribbleChanged");
        
        _utility.Events.Device.FaderStatus.FaderD.Scribble.OnBottomTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.Scribble.OnBottomTextChanged");
        _utility.Events.Device.FaderStatus.FaderD.Scribble.OnFileNameChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.Scribble.OnFileNameChanged");
        _utility.Events.Device.FaderStatus.FaderD.Scribble.OnInvertedChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.Scribble.OnInvertedChanged");
        _utility.Events.Device.FaderStatus.FaderD.Scribble.OnLeftTextChanged += (sender, args) => Console.WriteLine("Events.Device.FaderStatus.FaderD.Scribble.OnLeftTextChanged");

        #endregion

        #endregion

        #endregion
        
        #region Hardware

        //Will have no Events

        #endregion
        
        #region Levels

        _utility.Events.Device.Levels.OnLevelChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.OnLevelChanged");
        
        _utility.Events.Device.Levels.OnBleepLevelChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.OnBleepLevelChanged");
        _utility.Events.Device.Levels.OnDeEsserLevelChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.OnDeEsserLevelChanged");

        #region Levels.Volume

        //_utility.Events.Device.Levels.Volume.
        _utility.Events.Device.Levels.Volume.OnVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnChatVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnChatVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnConsoleVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnConsoleVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnGameVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnGameVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnHeadphonesVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnHeadphonesVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnLineInVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnLineInVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnLineOutVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnLineOutVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnMicVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnMicVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnMicMonitorVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnMicMonitorVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnMusicVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnMusicVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnSampleVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnSampleVolumeChanged");
        _utility.Events.Device.Levels.Volume.OnSystemVolumeChanged += (sender, args) => Console.WriteLine("Events.Device.Levels.Volume.OnSystemVolumeChanged");
            

        #endregion

        #endregion
        
        #region Lighting

        

        #endregion
        
        #region MicProfileName

        _utility.Events.Device.OnMicProfileChanged += (sender, args) => Console.WriteLine("Events.Device.OnMicProfileChanged");

        #endregion
        
        #region MicStatus

        //_utility.Events.Device.Mic
        _utility.Events.Device.Mic.OnMicStatusChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMicStatusChanged");
        _utility.Events.Device.Mic.OnEqualiserChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnEqualiserChanged");
        _utility.Events.Device.Mic.OnEqualiserMiniChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMiniEqualiserChanged");
        _utility.Events.Device.Mic.OnCompressorChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMicCompressorChanged");
        _utility.Events.Device.Mic.OnGainsChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMicGainsChanged");
        _utility.Events.Device.Mic.OnNoiseGateChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMicNoiseGateChanged");
        _utility.Events.Device.Mic.OnMicTypeChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.OnMicTypeChanged");

        #region MicStatus.Equaliser

        //_utility.Events.Device.Mic.Equaliser
        _utility.Events.Device.Mic.Equaliser.OnGainChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.OnGainChanged");
        _utility.Events.Device.Mic.Equaliser.OnFrequencyChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.OnFrequencyChanged");

        #region MicStatus.Equaliser.Gain

        //_utility.Events.Device.Mic.Equaliser.Gain
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer31HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer31HzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer63HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer63HzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer125HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer125HzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer250HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer250HzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer500HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer500HzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer1KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer1KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer2KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer2KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer4KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer4KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer8KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer8KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Gain.OnEqualizer16KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Gain.OnEqualizer16KHzChanged");

        #endregion

        #region MicStatus.Equaliser.Frequency

        //_utility.Events.Device.Mic.Equaliser.Frequency
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer31HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer31HzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer63HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer63HzChanged");

        #endregion

        #endregion
        
        #region MicStatus.EqualiserMini

        //_utility.Events.Device.Mic.MiniEqualiser
        _utility.Events.Device.Mic.EqualiserMini.OnGainMiniChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.OnGainMiniChanged");
        _utility.Events.Device.Mic.EqualiserMini.OnFrequencyMiniChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.OnFrequencyMiniChanged");

        #region MicStatus.EqualiserMini.GainMini

        //_utility.Events.Device.Mic.MiniEqualiser.GainMini
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer90HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer90HzChanged");
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer250HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer250HzChanged");
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer500HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer500HzChanged");
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer1KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer1KHzChanged");
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer3KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer3KHzChanged");
        _utility.Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer8KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.GainMini.OnEqualizer8KHzChanged");

        #endregion

        #region MicStatus.EqualiserMini.FrequencyMini

        //_utility.Events.Device.Mic.Equaliser.FrequencyMini
        _utility.Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer90HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer90HzChanged");
        _utility.Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer250HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer250HzChanged");
        _utility.Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer500HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.EqualiserMini.FrequencyMini.OnEqualizer500HzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer125HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer125HzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer250HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer250HzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer500HzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer500HzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer1KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer1KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer2KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer2KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer4KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer4KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer8KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer8KHzChanged");
        _utility.Events.Device.Mic.Equaliser.Frequency.OnEqualizer16KHzChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Equaliser.Frequency.OnEqualizer16KHzChanged");

        #endregion

        #endregion

        #region MicStatus.MicCompressor

        //_utility.Events.Device.Mic.Compressor
        _utility.Events.Device.Mic.Compressor.OnAttackChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Compressor.OnAttackChanged");
        _utility.Events.Device.Mic.Compressor.OnMakeUpGainChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Compressor.OnMakeUpGainChanged");
        _utility.Events.Device.Mic.Compressor.OnRatioChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Compressor.OnRatioChanged");
        _utility.Events.Device.Mic.Compressor.OnReleaseChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Compressor.OnReleaseChanged");
        _utility.Events.Device.Mic.Compressor.OnThresholdChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.Compressor.OnThresholdChanged");

        #endregion
        
        #region MicStatus.MicGains

        //_utility.Events.Device.Mic.MicGains
        _utility.Events.Device.Mic.MicGains.OnCondenserGainChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.MicGains.OnCondenserGainChanged");
        _utility.Events.Device.Mic.MicGains.OnDynamicGainChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.MicGains.OnDynamicGainChanged");
        _utility.Events.Device.Mic.MicGains.OnJackGainChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.MicGains.OnJackGainChanged");

        #endregion

        #region MicStatus.NoiseGate

        //_utility.Events.Device.Mic.NoiseGate
        _utility.Events.Device.Mic.NoiseGate.OnAttackChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.NoiseGate.OnAttackChanged");
        _utility.Events.Device.Mic.NoiseGate.OnAttenuationChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.NoiseGate.OnAttenuationChanged");
        _utility.Events.Device.Mic.NoiseGate.OnEnabledChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.NoiseGate.OnEnabledChanged");
        _utility.Events.Device.Mic.NoiseGate.OnReleaseChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.NoiseGate.OnReleaseChanged");
        _utility.Events.Device.Mic.NoiseGate.OnThresholdChanged += (sender, args) => Console.WriteLine("Events.Device.Mic.NoiseGate.OnThresholdChanged");

        #endregion

        #endregion

        #region ProfileName

        _utility.Events.Device.OnProfileChanged += (sender, args) => Console.WriteLine("Events.Device.OnProfileChanged");

        #endregion

        #region Router

        _utility.Events.Device.Router.OnRoutingChanged += (sender, args) => Console.WriteLine("Events.Device.Router.OnRoutingChanged"); 

        #endregion

        #region Sampler

        _utility.Events.Device.Sampler.SamplerBank.OnSamplerBanksChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.OnSamplerBanksChanged");

        #region Sampler.A

        _utility.Events.Device.Sampler.SamplerBank.A.OnSamplerBankChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.OnSamplerBankChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.A.OnBottomLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.OnBottomLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.OnBottomRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.OnBottomRightChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.OnTopLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.OnTopLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.OnTopRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.OnTopRightChanged");

        #region Sampler.A.BottomLeft

        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.OnSamplesChanged");

        #region Sampler.A.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.A.BottomRight

        _utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomRight.OnSamplesChanged");
        
        #region Sampler.A.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.A.TopLeft

        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.OnSamplesChanged");
        
        #region Sampler.A.TopLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.A.TopRight

        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.OnSamplesChanged");
        
        #region Sampler.A.TopRight.Samples

        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.A.TopRight.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.B

        _utility.Events.Device.Sampler.SamplerBank.B.OnSamplerBankChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.OnSamplerBankChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.B.OnBottomLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.OnBottomLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.OnBottomRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.OnBottomRightChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.OnTopLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.OnTopLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.OnTopRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.OnTopRightChanged");

        #region Sampler.B.BottomLeft

        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.OnSamplesChanged");

        #region Sampler.B.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.B.BottomRight

        _utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomRight.OnSamplesChanged");
        
        #region Sampler.B.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.B.TopLeft

        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.OnSamplesChanged");
        
        #region Sampler.B.TopLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.B.TopRight

        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.OnSamplesChanged");
        
        #region Sampler.B.TopRight.Samples

        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.B.TopRight.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.C

        _utility.Events.Device.Sampler.SamplerBank.C.OnSamplerBankChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.OnSamplerBankChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.C.OnBottomLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.OnBottomLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.OnBottomRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.OnBottomRightChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.OnTopLeftChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.OnTopLeftChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.OnTopRightChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.OnTopRightChanged");

        #region Sampler.C.BottomLeft

        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.OnSamplesChanged");

        #region Sampler.C.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.C.BottomRight

        _utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomRight.OnSamplesChanged");
        
        #region Sampler.C.BottomLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.BottomLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.C.TopLeft

        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.OnSamplesChanged");
        
        #region Sampler.C.TopLeft.Samples

        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopLeft.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #region Sampler.C.TopRight

        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnBankBaseChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnBankBaseChanged");
        
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnFunctionChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnFunctionChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnIsPlayingChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnIsPlayingChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnOrderChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnOrderChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnSamplesChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.OnSamplesChanged");
        
        #region Sampler.C.TopRight.Samples

        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnSampleChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnSampleChanged");

        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnNameChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnNameChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnStartPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnStartPctChanged");
        _utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnStopPctChanged += (sender, args) => Console.WriteLine("_utility.Events.Device.Sampler.SamplerBank.C.TopRight.Samples.OnStopPctChanged");

        #endregion

        #endregion

        #endregion

        #endregion

        #region Settings

        _utility.Events.Device.Settings.OnSettingsChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.OnSettingsChanged");
        
        _utility.Events.Device.Settings.OnMuteHoldDurationChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.OnMuteHoldDurationChanged");
        _utility.Events.Device.Settings.OnVcMuteAlsoMuteCmChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.OnVcMuteAlsoMuteCmChanged");

        #region GuiDisplayEvents

        _utility.Events.Device.Settings.GuiDisplay.OnDisplayChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.GuiDisplay.OnDisplayChanged");
        _utility.Events.Device.Settings.GuiDisplay.OnCompressorChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.GuiDisplay.OnCompressorChanged");
        _utility.Events.Device.Settings.GuiDisplay.OnEqualiserChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.GuiDisplay.OnEqualiserChanged");
        _utility.Events.Device.Settings.GuiDisplay.OnEqualiserFineChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.GuiDisplay.OnEqualiserFineChanged");
        _utility.Events.Device.Settings.GuiDisplay.OnGateChanged += (sender, args) => Console.WriteLine("Events.Device.Settings.GuiDisplay.OnGateChanged");

        #endregion

        #endregion
    }
}