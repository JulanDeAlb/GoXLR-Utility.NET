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
        _utility.Events.Device.ButtonDown.OnSamplerClearButtonDown += (sender, args) => Console.WriteLine("Events.Device.ButtonDown.OnSamplerClearButtonDown");
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

        _utility.Events.Device.Effect.OnEffectsChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.OnEffectsChanged");
        _utility.Events.Device.Effect.OnActivePresetChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.OnActivePresetChanged");
        _utility.Events.Device.Effect.OnCurrentEffectChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.OnCurrentEffectChanged");
        _utility.Events.Device.Effect.OnPresetNamesChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.OnPresetNamesChanged");
        _utility.Events.Device.Effect.OnEffectEnabledChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.OnEffectEnabledChanged");

        #region Effects.Current

        _utility.Events.Device.Effect.Current.OnEchoChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnEchoChanged");
        _utility.Events.Device.Effect.Current.OnGenderChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnGenderChanged");
        _utility.Events.Device.Effect.Current.OnHardTuneChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnHardTuneChanged");
        _utility.Events.Device.Effect.Current.OnMegaphoneChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnMegaphoneChanged");
        _utility.Events.Device.Effect.Current.OnPitchChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnPitchChanged");
        _utility.Events.Device.Effect.Current.OnRobotChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.OnRobotChanged");

        #region Effects.Current.Echo

        _utility.Events.Device.Effect.Current.Echo.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnAmountChanged");
        _utility.Events.Device.Effect.Current.Echo.OnDelayLeftChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnDelayLeftChanged");
        _utility.Events.Device.Effect.Current.Echo.OnDelayRightChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnDelayRightChanged");
        _utility.Events.Device.Effect.Current.Echo.OnFeedbackChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnFeedbackChanged");
        _utility.Events.Device.Effect.Current.Echo.OnFeedbackLeftChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnFeedbackLeftChanged");
        _utility.Events.Device.Effect.Current.Echo.OnFeedbackRightChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnFeedbackRightChanged");
        _utility.Events.Device.Effect.Current.Echo.OnFeedbackXfbRtLChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnFeedbackXfbRtLChanged");
        _utility.Events.Device.Effect.Current.Echo.OnFeedbackXfbLtRChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnFeedbackXfbLtRChanged");
        _utility.Events.Device.Effect.Current.Echo.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnStyleChanged");
        _utility.Events.Device.Effect.Current.Echo.OnTempoChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Echo.OnTempoChanged");

        #endregion

        #region Effects.Current.Gender

        _utility.Events.Device.Effect.Current.Gender.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Gender.OnAmountChanged");
        _utility.Events.Device.Effect.Current.Gender.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Gender.OnStyleChanged");

        #endregion

        #region Effects.Current.HardTune

        _utility.Events.Device.Effect.Current.HardTune.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnAmountChanged");
        _utility.Events.Device.Effect.Current.HardTune.OnIsEnabledChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnIsEnabledChanged");
        _utility.Events.Device.Effect.Current.HardTune.OnRateChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnRateChanged");
        _utility.Events.Device.Effect.Current.HardTune.OnSourceChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnSourceChanged");
        _utility.Events.Device.Effect.Current.HardTune.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnStyleChanged");
        _utility.Events.Device.Effect.Current.HardTune.OnWindowChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.HardTune.OnWindowChanged");

        #endregion

        #region Effects.Current.Megaphone

        _utility.Events.Device.Effect.Current.Megaphone.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Megaphone.OnAmountChanged");
        _utility.Events.Device.Effect.Current.Megaphone.OnIsEnabledChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Megaphone.OnIsEnabledChanged");
        _utility.Events.Device.Effect.Current.Megaphone.OnRateChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Megaphone.OnRateChanged");
        _utility.Events.Device.Effect.Current.Megaphone.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Megaphone.OnStyleChanged");

        #endregion

        #region Effects.Current.Pitch

        _utility.Events.Device.Effect.Current.Pitch.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Pitch.OnAmountChanged");
        _utility.Events.Device.Effect.Current.Pitch.OnCharacterChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Pitch.OnCharacterChanged");
        _utility.Events.Device.Effect.Current.Pitch.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Pitch.OnStyleChanged");

        #endregion

        #region Effects.Current.Reverb

        _utility.Events.Device.Effect.Current.Reverb.OnAmountChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnAmountChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnDecayChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnDecayChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnDiffuseChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnDiffuseChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnEarlyLevelChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnEarlyLevelChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnHiColourChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnHiColourChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnHiFactorChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnHiFactorChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnLoColourChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnLoColourChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnModDepthChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnModDepthChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnModSpeedChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnModSpeedChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnPreDelayChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnPreDelayChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnStyleChanged");
        _utility.Events.Device.Effect.Current.Reverb.OnTailLevelChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Reverb.OnTailLevelChanged");

        #endregion

        #region Effects.Current.Robot

        _utility.Events.Device.Effect.Current.Robot.OnDryMixChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnDryMixChanged");
        _utility.Events.Device.Effect.Current.Robot.OnIsEnabledChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnIsEnabledChanged");
        _utility.Events.Device.Effect.Current.Robot.OnHighFreqChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnHighFreqChanged");
        _utility.Events.Device.Effect.Current.Robot.OnHighGainChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnHighGainChanged");
        _utility.Events.Device.Effect.Current.Robot.OnHighWidthChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnHighWidthChanged");
        _utility.Events.Device.Effect.Current.Robot.OnLowFreqChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnLowFreqChanged");
        _utility.Events.Device.Effect.Current.Robot.OnLowGainChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnLowGainChanged");
        _utility.Events.Device.Effect.Current.Robot.OnLowWidthChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnLowWidthChanged");
        _utility.Events.Device.Effect.Current.Robot.OnMidFreqChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnMidFreqChanged");
        _utility.Events.Device.Effect.Current.Robot.OnMidGainChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnMidGainChanged");
        _utility.Events.Device.Effect.Current.Robot.OnMidWidthChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnMidWidthChanged");
        _utility.Events.Device.Effect.Current.Robot.OnPulseWidthChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnPulseWidthChanged");
        _utility.Events.Device.Effect.Current.Robot.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnStyleChanged");
        _utility.Events.Device.Effect.Current.Robot.OnThresholdChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnThresholdChanged");
        _utility.Events.Device.Effect.Current.Robot.OnWaveFromChanged += (sender, args) => Console.WriteLine("Events.Device.Effect.Current.Robot.OnWaveFromChanged");

        #endregion

        #endregion
        
        #region Effects.PresetNames

        _utility.Events.Device.Effect.PresetNames.OnPreset1Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset1Changed");
        _utility.Events.Device.Effect.PresetNames.OnPreset2Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset2Changed");
        _utility.Events.Device.Effect.PresetNames.OnPreset3Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset3Changed");
        _utility.Events.Device.Effect.PresetNames.OnPreset4Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset4Changed");
        _utility.Events.Device.Effect.PresetNames.OnPreset5Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset5Changed");
        _utility.Events.Device.Effect.PresetNames.OnPreset6Changed += (sender, args) => Console.WriteLine("Events.Device.Effect.PresetNames.OnPreset6Changed");

        #endregion

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

        _utility.Events.Device.Lighting.OnLightningChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnLightningChanged");
        _utility.Events.Device.Lighting.OnButtonsChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnButtonsChanged");
        _utility.Events.Device.Lighting.OnEncodersChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnEncodersChanged");
        _utility.Events.Device.Lighting.OnFaderChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnFaderChanged");
        _utility.Events.Device.Lighting.OnSamplerChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnSamplerChanged");
        _utility.Events.Device.Lighting.OnSimpleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.OnSimpleChanged");

        #region Lighting.Button

        _utility.Events.Device.Lighting.Button.OnBleepChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnBleepChanged");
        _utility.Events.Device.Lighting.Button.OnCoughChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnCoughChanged");
        _utility.Events.Device.Lighting.Button.OnEffectFxChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectFxChanged");
        _utility.Events.Device.Lighting.Button.OnEffectHardTuneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectHardTuneChanged");
        _utility.Events.Device.Lighting.Button.OnEffectMegaphoneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectMegaphoneChanged");
        _utility.Events.Device.Lighting.Button.OnEffectRobotChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectRobotChanged");
        _utility.Events.Device.Lighting.Button.OnEffectSelect1Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect1Changed");
        _utility.Events.Device.Lighting.Button.OnEffectSelect2Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect2Changed");
        _utility.Events.Device.Lighting.Button.OnEffectSelect3Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect3Changed");
        _utility.Events.Device.Lighting.Button.OnEffectSelect4Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect4Changed");
        _utility.Events.Device.Lighting.Button.OnEffectSelect5Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect5Changed");
        _utility.Events.Device.Lighting.Button.OnEffectSelect6Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnEffectSelect6Changed");
        _utility.Events.Device.Lighting.Button.OnFader1MuteChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnFader1MuteChanged");
        _utility.Events.Device.Lighting.Button.OnFader2MuteChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnFader2MuteChanged");
        _utility.Events.Device.Lighting.Button.OnFader3MuteChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnFader3MuteChanged");
        _utility.Events.Device.Lighting.Button.OnFader4MuteChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.OnFader4MuteChanged");

        #region Lighting.Button.Bleep

        _utility.Events.Device.Lighting.Button.Bleep.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Bleep.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Bleep.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Bleep.OnOffStyleChanged");

        #region Lighting.Button.Bleep.Colour

        _utility.Events.Device.Lighting.Button.Bleep.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Bleep.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Bleep.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Bleep.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.Cough

        _utility.Events.Device.Lighting.Button.Cough.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Cough.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Cough.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Cough.OnOffStyleChanged");

        #region Lighting.Button.Cough.Colour

        _utility.Events.Device.Lighting.Button.Cough.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Cough.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Cough.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Cough.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectFx

        _utility.Events.Device.Lighting.Button.EffectFx.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectFx.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectFx.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectFx.OnOffStyleChanged");

        #region Lighting.Button.EffectFx.Colour

        _utility.Events.Device.Lighting.Button.EffectFx.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectFx.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectFx.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectFx.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectHardTune

        _utility.Events.Device.Lighting.Button.EffectHardTune.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectHardTune.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectHardTune.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectHardTune.OnOffStyleChanged");

        #region Lighting.Button.EffectHardTune.Colour

        _utility.Events.Device.Lighting.Button.EffectHardTune.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectHardTune.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectHardTune.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectHardTune.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectMegaphone

        _utility.Events.Device.Lighting.Button.EffectMegaphone.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectMegaphone.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectMegaphone.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectMegaphone.OnOffStyleChanged");

        #region Lighting.Button.EffectMegaphone.Colour

        _utility.Events.Device.Lighting.Button.EffectMegaphone.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectMegaphone.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectMegaphone.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectMegaphone.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectRobot

        _utility.Events.Device.Lighting.Button.EffectRobot.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectRobot.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectRobot.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectRobot.OnOffStyleChanged");

        #region Lighting.Button.EffectRobot.Colour

        _utility.Events.Device.Lighting.Button.EffectRobot.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectRobot.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectRobot.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectRobot.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect1

        _utility.Events.Device.Lighting.Button.EffectSelect1.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect1.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect1.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect1.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect1.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect1.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect1.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect1.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect1.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect2

        _utility.Events.Device.Lighting.Button.EffectSelect2.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect2.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect2.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect2.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect2.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect2.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect2.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect2.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect2.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect3

        _utility.Events.Device.Lighting.Button.EffectSelect3.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect3.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect3.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect3.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect3.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect3.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect3.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect3.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect3.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect4

        _utility.Events.Device.Lighting.Button.EffectSelect4.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect4.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect4.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect4.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect4.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect4.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect4.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect4.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect4.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect5

        _utility.Events.Device.Lighting.Button.EffectSelect5.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect5.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect5.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect5.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect5.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect5.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect5.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect5.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect5.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect6

        _utility.Events.Device.Lighting.Button.EffectSelect6.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect6.OnColourChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect6.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect6.OnOffStyleChanged");

        #region Lighting.Button.EffectSelect6.Colour

        _utility.Events.Device.Lighting.Button.EffectSelect6.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect6.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.EffectSelect6.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.EffectSelect6.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader1Mute

        _utility.Events.Device.Lighting.Button.Fader1Mute.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader1Mute.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Fader1Mute.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader1Mute.OnOffStyleChanged");

        #region Lighting.Button.Fader1Mute.Colour

        _utility.Events.Device.Lighting.Button.Fader1Mute.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader1Mute.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Fader1Mute.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader1Mute.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader2Mute

        _utility.Events.Device.Lighting.Button.Fader2Mute.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader2Mute.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Fader2Mute.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader2Mute.OnOffStyleChanged");

        #region Lighting.Button.Fader2Mute.Colour

        _utility.Events.Device.Lighting.Button.Fader2Mute.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader2Mute.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Fader2Mute.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader2Mute.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader3Mute

        _utility.Events.Device.Lighting.Button.Fader3Mute.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader3Mute.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Fader3Mute.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader3Mute.OnOffStyleChanged");

        #region Lighting.Button.Fader3Mute.Colour

        _utility.Events.Device.Lighting.Button.Fader3Mute.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader3Mute.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Fader3Mute.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader3Mute.Colour.OnColourTwoChanged");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader4Mute

        _utility.Events.Device.Lighting.Button.Fader4Mute.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader4Mute.OnColourChanged");
        _utility.Events.Device.Lighting.Button.Fader4Mute.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader4Mute.OnOffStyleChanged");

        #region Lighting.Button.Fader4Mute.Colour

        _utility.Events.Device.Lighting.Button.Fader4Mute.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader4Mute.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Button.Fader4Mute.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Button.Fader4Mute.Colour.OnColourTwoChanged");

        #endregion

        #endregion

        #endregion

        #region Lighting.Encoder

        _utility.Events.Device.Lighting.Encoder.OnEchoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.OnEchoChanged");
        _utility.Events.Device.Lighting.Encoder.OnGenderChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.OnGenderChanged");
        _utility.Events.Device.Lighting.Encoder.OnPitchChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.OnPitchChanged");
        _utility.Events.Device.Lighting.Encoder.OnReverbChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.OnReverbChanged");

        #region Lighting.Encoder.Echo

        _utility.Events.Device.Lighting.Encoder.Echo.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Echo.OnColourOneChanged");
        _utility.Events.Device.Lighting.Encoder.Echo.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Echo.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Encoder.Echo.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Echo.OnColourThreeChanged");

        #endregion

        #region Lighting.Encoder.Gender

        _utility.Events.Device.Lighting.Encoder.Gender.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Gender.OnColourOneChanged");
        _utility.Events.Device.Lighting.Encoder.Gender.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Gender.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Encoder.Gender.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Gender.OnColourThreeChanged");

        #endregion

        #region Lighting.Encoder.Pitch

        _utility.Events.Device.Lighting.Encoder.Pitch.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Pitch.OnColourOneChanged");
        _utility.Events.Device.Lighting.Encoder.Pitch.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Pitch.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Encoder.Pitch.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Pitch.OnColourThreeChanged");

        #endregion

        #region Lighting.Encoder.Reverb

        _utility.Events.Device.Lighting.Encoder.Reverb.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Reverb.OnColourOneChanged");
        _utility.Events.Device.Lighting.Encoder.Reverb.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Reverb.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Encoder.Reverb.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Encoder.Reverb.OnColourThreeChanged");

        #endregion

        #endregion

        #region Lighting.Fader

        _utility.Events.Device.Lighting.Fader.OnFaderAChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.OnFaderAChanged");
        _utility.Events.Device.Lighting.Fader.OnFaderBChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.OnFaderBChanged");
        _utility.Events.Device.Lighting.Fader.OnFaderCChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.OnFaderCChanged");
        _utility.Events.Device.Lighting.Fader.OnFaderDChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.OnFaderDChanged");

        #region Lighting.Fader.A

        _utility.Events.Device.Lighting.Fader.A.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.A.OnColourChanged");
        _utility.Events.Device.Lighting.Fader.A.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.A.OnStyleChanged");
        
        #region Lighting.Fader.A.Colour

        _utility.Events.Device.Lighting.Fader.A.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.A.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Fader.A.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.A.Colour.OnColourTwoChanged");

        #endregion

        #endregion

        #region Lighting.Fader.B

        _utility.Events.Device.Lighting.Fader.B.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.B.OnColourChanged");
        _utility.Events.Device.Lighting.Fader.B.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.B.OnStyleChanged");
        
        #region Lighting.Fader.B.Colour

        _utility.Events.Device.Lighting.Fader.B.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.B.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Fader.B.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.B.Colour.OnColourTwoChanged");

        #endregion

        #endregion

        #region Lighting.Fader.C

        _utility.Events.Device.Lighting.Fader.C.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.C.OnColourChanged");
        _utility.Events.Device.Lighting.Fader.C.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.C.OnStyleChanged");
        
        #region Lighting.Fader.C.Colour

        _utility.Events.Device.Lighting.Fader.C.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.C.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Fader.C.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.C.Colour.OnColourTwoChanged");

        #endregion

        #endregion

        #region Lighting.Fader.D

        _utility.Events.Device.Lighting.Fader.D.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.D.OnColourChanged");
        _utility.Events.Device.Lighting.Fader.D.OnStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.D.OnStyleChanged");
        
        #region Lighting.Fader.D.Colour

        _utility.Events.Device.Lighting.Fader.D.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.D.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Fader.D.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Fader.D.Colour.OnColourTwoChanged");

        #endregion

        #endregion

        #endregion

        #region Lighting.Sampler

        _utility.Events.Device.Lighting.Sampler.OnSamplerAChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.OnSamplerAChanged");
        _utility.Events.Device.Lighting.Sampler.OnSamplerBChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.OnSamplerBChanged");
        _utility.Events.Device.Lighting.Sampler.OnSamplerCChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.OnSamplerCChanged");

        #region Lighting.Sampler.A

        _utility.Events.Device.Lighting.Sampler.A.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.A.OnColourChanged");
        _utility.Events.Device.Lighting.Sampler.A.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.A.OnOffStyleChanged");

        #region Lighting.Sampler.A.Colour

        _utility.Events.Device.Lighting.Sampler.A.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.A.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Sampler.A.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.A.Colour.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Sampler.A.Colour.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.A.Colour.OnColourThreeChanged");

        #endregion

        #endregion

        #region Lighting.Sampler.B

        _utility.Events.Device.Lighting.Sampler.B.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.B.OnColourChanged");
        _utility.Events.Device.Lighting.Sampler.B.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.B.OnOffStyleChanged");

        #region Lighting.Sampler.B.Colour

        _utility.Events.Device.Lighting.Sampler.B.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.B.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Sampler.B.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.B.Colour.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Sampler.B.Colour.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.B.Colour.OnColourThreeChanged");

        #endregion

        #endregion

        #region Lighting.Sampler.C

        _utility.Events.Device.Lighting.Sampler.C.OnColourChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.C.OnColourChanged");
        _utility.Events.Device.Lighting.Sampler.C.OnOffStyleChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.C.OnOffStyleChanged");

        #region Lighting.Sampler.C.Colour

        _utility.Events.Device.Lighting.Sampler.C.Colour.OnColourOneChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.C.Colour.OnColourOneChanged");
        _utility.Events.Device.Lighting.Sampler.C.Colour.OnColourTwoChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.C.Colour.OnColourTwoChanged");
        _utility.Events.Device.Lighting.Sampler.C.Colour.OnColourThreeChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Sampler.C.Colour.OnColourThreeChanged");

        #endregion

        #endregion

        #endregion

        #region Lighting.Simple

        _utility.Events.Device.Lighting.Simple.OnAccentChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnAccentChanged");
        _utility.Events.Device.Lighting.Simple.OnScribble1Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnScribble1Changed");
        _utility.Events.Device.Lighting.Simple.OnScribble2Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnScribble2Changed");
        _utility.Events.Device.Lighting.Simple.OnScribble3Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnScribble3Changed");
        _utility.Events.Device.Lighting.Simple.OnScribble4Changed += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnScribble4Changed");
        _utility.Events.Device.Lighting.Simple.OnGlobalChanged += (sender, args) => Console.WriteLine("Events.Device.Lighting.Simple.OnGlobalChanged");

        #endregion

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