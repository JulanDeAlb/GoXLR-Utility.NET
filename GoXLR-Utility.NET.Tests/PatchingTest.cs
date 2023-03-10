using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;
using Xunit.Abstractions;

namespace GoXLR_Utility.NET.Tests;

public class PatchingTest
{
    private readonly string _statusString;
    private readonly string _patchString;
    private readonly string _smallPatchString;
    private readonly MessageHandler _messageHandler;

    public PatchingTest(ITestOutputHelper output)
    {
        _messageHandler = new MessageHandler(new XUnitLogger(output));

        var assembly = Assembly.GetExecutingAssembly();

        using var stream = assembly.GetManifestResourceStream("GoXLR_Utility.NET.Tests.EmbeddedResources.Status.json");
        using var reader = new StreamReader(stream!);
        _statusString = reader.ReadToEnd();

        using var stream2 = assembly.GetManifestResourceStream("GoXLR_Utility.NET.Tests.EmbeddedResources.Patch.json");
        using var reader2 = new StreamReader(stream2!);
        _patchString = reader2.ReadToEnd();

        using var stream3 = assembly.GetManifestResourceStream("GoXLR_Utility.NET.Tests.EmbeddedResources.Patch.json");
        using var reader3 = new StreamReader(stream3!);
        _smallPatchString = reader3.ReadToEnd();
    }

    [Fact]
    public void PatchStatus()
    {
        //For now i manually test every Value, will be rewritten with Utility saving overhaul in 2.0

        _messageHandler.HandleMessage(_statusString);

        Assert.NotNull(_messageHandler.Status);

        //Apply all patches
        _messageHandler.HandleMessage(_patchString);

        #region Config

        Assert.Equal("1.0.0", _messageHandler.Status.Config.DaemonVersion);
        Assert.False(_messageHandler.Status.Config.AutostartEnabled);
        Assert.False(_messageHandler.Status.Config.ShowTrayIcon);

        #endregion

        #region Device

        Assert.Equal("5", _messageHandler.Status.Mixers["SerialNumber"].MicProfileName);
        Assert.Equal("6", _messageHandler.Status.Mixers["SerialNumber"].ProfileName);

        #region ButtonDown

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Bleep);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Cough);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectFx);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectHardTune);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectMegaphone);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectRobot);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect1);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect2);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect3);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect4);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect5);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.EffectSelect6);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Fader1Mute);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Fader2Mute);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Fader3Mute);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.Fader4Mute);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerClear);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerSelectA);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerSelectB);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerSelectC);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerBottomLeft);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerBottomRight);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerTopLeft);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].ButtonDown.SamplerTopRight);

        #endregion

        #region CoughButton

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].CoughButton.IsToggle);
        Assert.Equal(MuteFunction.ToPhones, _messageHandler.Status.Mixers["SerialNumber"].CoughButton.MuteFunction);
        Assert.Equal(MuteState.MutedToX, _messageHandler.Status.Mixers["SerialNumber"].CoughButton.MuteState);

        #endregion

        #region Effects

        Assert.Equal(EffectBankPresets.Preset1, _messageHandler.Status.Mixers["SerialNumber"].Effects.ActivePreset);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Effects.IsEnabled);

        #region Effects.Current.Echo

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.Amount);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.DelayLeft);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.DelayRight);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.Feedback);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackLeft);
        Assert.Equal(16, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackRight);
        Assert.Equal(17, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackXfbRtL);
        Assert.Equal(18, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackXfbLtR);
        Assert.Equal(EchoStyle.PingPong , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.Style);
        Assert.Equal(19, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Echo.Tempo);

        #region Effects.Current.Gender

        Assert.Equal(5, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Gender.Amount);
        Assert.Equal(GenderStyle.Wide , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Gender.Style);

        #endregion

        #region Effects.Current.HardTune

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.Amount);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.IsEnabled);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.Rate);
        Assert.Equal(HardTuneSource.LineIn, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.Source);
        Assert.Equal(HardTuneStyle.Natural , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.Style);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.HardTune.Window);

        #endregion

        #region Effects.Current.Megaphone

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Megaphone.Amount);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Megaphone.IsEnabled);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Megaphone.PostGain);
        Assert.Equal(MegaphoneStyle.OnThePhone , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Megaphone.Style);

        #endregion

        #region Effects.Current.Pitch

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Pitch.Amount);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Pitch.Character);
        Assert.Equal(PitchStyle.Narrow , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Pitch.Style);

        #endregion

        #region Effects.Current.Reverb

        Assert.Equal(21, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.Amount);
        Assert.Equal(22, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.Decay);
        Assert.Equal(23, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.Diffuse);
        Assert.Equal(24, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.EarlyLevel);
        Assert.Equal(25, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.HiColour);
        Assert.Equal(26, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.HiFactor);
        Assert.Equal(27, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.LoColour);
        Assert.Equal(28, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.ModDepth);
        Assert.Equal(29, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.ModSpeed);
        Assert.Equal(30, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.PreDelay);
        Assert.Equal(ReverbStyle.Library , _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.Style);
        Assert.Equal(31, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Reverb.TailLevel);

        #endregion

        #region Effects.Current.Robot

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.DryMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.IsEnabled);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.HighFreq);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.HighGain);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.HighWidth);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.LowFreq);
        Assert.Equal(16, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.LowGain);
        Assert.Equal(17, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.LowWidth);
        Assert.Equal(18, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.MidFreq);
        Assert.Equal(19, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.MidGain);
        Assert.Equal(20, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.MidWidth);
        Assert.Equal(21, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.PulseWidth);
        Assert.Equal(RobotStyle.Robot1, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.Style);
        Assert.Equal(22, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.Threshold);
        Assert.Equal(23, _messageHandler.Status.Mixers["SerialNumber"].Effects.Current.Robot.WaveFrom);

        #endregion

        #endregion

        #region Effects.PresetNames

        Assert.Equal("Preset1", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset1);
        Assert.Equal("Preset2", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset2);
        Assert.Equal("Preset3", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset3);
        Assert.Equal("Preset4", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset4);
        Assert.Equal("Preset5", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset5);
        Assert.Equal("Preset6", _messageHandler.Status.Mixers["SerialNumber"].Effects.PresetNames.Preset6);

        #endregion

        #endregion

        #region FaderStatus

        #region FaderStatus.FaderA

        Assert.Equal(ChannelName.Console, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.Channel);
        Assert.Equal(MuteFunction.ToStream, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.MuteType);
        Assert.Equal(MuteState.MutedToAll, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.MuteState);


        #region FaderStatus.FaderA.Scribble

        Assert.Equal("bottomText", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.BottomText);
        Assert.Equal("fileName", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.FileName);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.Inverted);
        Assert.Equal("leftText", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderB

        Assert.Equal(ChannelName.Console, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.Channel);
        Assert.Equal(MuteFunction.ToVoiceChat, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.MuteType);
        Assert.Equal(MuteState.MutedToX, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.MuteState);


        #region FaderStatus.FaderB.Scribble

        Assert.Equal("bottomText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.BottomText);
        Assert.Equal("fileName2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.FileName);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.Inverted);
        Assert.Equal("leftText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderC

        Assert.Equal(ChannelName.Console, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.Channel);
        Assert.Equal(MuteFunction.ToVoiceChat, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.MuteType);
        Assert.Equal(MuteState.MutedToX, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.MuteState);


        #region FaderStatus.FaderC.Scribble

        Assert.Equal("bottomText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.BottomText);
        Assert.Equal("fileName2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.FileName);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.Inverted);
        Assert.Equal("leftText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderD

        Assert.Equal(ChannelName.Console, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.Channel);
        Assert.Equal(MuteFunction.ToVoiceChat, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.MuteType);
        Assert.Equal(MuteState.MutedToX, _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.MuteState);


        #region FaderStatus.FaderD.Scribble

        Assert.Equal("bottomText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.BottomText);
        Assert.Equal("fileName2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.FileName);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.Inverted);
        Assert.Equal("leftText2", _messageHandler.Status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.LeftText);

        #endregion

        #endregion

        #endregion

        #region Hardware

        Assert.Equal("Full", _messageHandler.Status.Mixers["SerialNumber"].Hardware.DeviceType);
        Assert.Equal(DateTimeOffset.Parse("2020-06-23"), _messageHandler.Status.Mixers["SerialNumber"].Hardware.ManufacturedDate);
        Assert.Equal("SerialNumber", _messageHandler.Status.Mixers["SerialNumber"].Hardware.SerialNumber);

        #region Hardware.UsbDevice

        Assert.Equal(2, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Address);
        Assert.Equal(1, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.BusNumber);
        Assert.Equal("USB\\Anything\\Anything", _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Identifier);
        Assert.Equal("TC-Helicon", _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.ManufacturerName);
        Assert.Equal("GoXLR", _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.ProductName);

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Version.Count);
        Assert.Equal(2, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[0]);
        Assert.Equal(1, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[1]);
        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[2]);

        #endregion

        #region Hardware.Versions

        Assert.Equal(4, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Dice.Count);
        Assert.Equal(1, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Dice[0]);
        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Dice[1]);
        Assert.Equal(9, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Dice[2]);
        Assert.Equal(100, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Dice[3]);

        Assert.Equal(4, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Firmware.Count);
        Assert.Equal(1, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Firmware[0]);
        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Firmware[1]);
        Assert.Equal(44, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Firmware[2]);
        Assert.Equal(106, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.Firmware[3]);

        Assert.Equal(7, _messageHandler.Status.Mixers["SerialNumber"].Hardware.Versions.FpgaCount);

        #endregion

        #endregion

        #region Levels


        Assert.Equal(-20, _messageHandler.Status.Mixers["SerialNumber"].Levels.Bleep);
        Assert.Equal(60, _messageHandler.Status.Mixers["SerialNumber"].Levels.DeEsser);

        #region Levels.Volume

        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Chat);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Console);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Game);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Headphones);
        Assert.Equal(16, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.LineIn);
        Assert.Equal(17, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.LineOut);
        Assert.Equal(18, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Mic);
        Assert.Equal(19, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.MicMonitor);
        Assert.Equal(20, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Music);
        Assert.Equal(21, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.Sample);
        Assert.Equal(22, _messageHandler.Status.Mixers["SerialNumber"].Levels.Volumes.System);

        #endregion

        #endregion

        #region Lighting

        #region Lighting.Button

        #region Lighting.Button.Bleep

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Bleep.OffStyle);

        #region Lighting.Button.Bleep.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Bleep.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Bleep.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.Cough

        Assert.Equal(LightingOffStyle.Colour2, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Cough.OffStyle);

        #region Lighting.Button.Cough.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Cough.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.Cough.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectFx

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectFx.OffStyle);

        #region Lighting.Button.EffectFx.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectFx.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectFx.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectHardTune

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.OffStyle);

        #region Lighting.Button.EffectHardTune.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectMegaphone

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.OffStyle);

        #region Lighting.Button.EffectMegaphone.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectRobot

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.OffStyle);

        #region Lighting.Button.EffectRobot.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect1

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.OffStyle);

        #region Lighting.Button.EffectSelect1.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect2

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.OffStyle);

        #region Lighting.Button.EffectSelect2.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect3

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.OffStyle);

        #region Lighting.Button.EffectSelect3.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect4

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.OffStyle);

        #region Lighting.Button.EffectSelect4.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect5

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.OffStyle);

        #region Lighting.Button.EffectSelect5.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect6

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.OffStyle);

        #region Lighting.Button.EffectSelect6.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderAMute

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.OffStyle);

        #region Lighting.Button.FaderAMute.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderBMute

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.OffStyle);

        #region Lighting.Button.FaderBMute.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderCMute

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.OffStyle);

        #region Lighting.Button.FaderCMute.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderDMute

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.OffStyle);

        #region Lighting.Button.FaderDMute.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.Colour.ColourTwo);

        #endregion

        #endregion

        #endregion

        #region Lighting.Encoder

        #region Lighting.Encoder.Echo

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourThree);

        #endregion

        #region Lighting.Encoder.Gender

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourThree);

        #endregion

        #region Lighting.Encoder.Pitch

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourThree);

        #endregion

        #region Lighting.Encoder.Reverb

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourThree);

        #endregion

        #endregion

        #region Lighting.Fader

        #region Lighting.Fader.FaderA

        Assert.Equal(FaderDisplayStyle.GradientMeter, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Style);

        #region Lighting.Fader.FaderA.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderB

        Assert.Equal(FaderDisplayStyle.GradientMeter, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Style);

        #region Lighting.Fader.FaderB.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderC

        Assert.Equal(FaderDisplayStyle.GradientMeter, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Style);

        #region Lighting.Fader.FaderC.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderD

        Assert.Equal(FaderDisplayStyle.GradientMeter, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Style);

        #region Lighting.Fader.FaderD.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Colour.ColourTwo);

        #endregion

        #endregion

        #endregion

        #region Lighting.Sampler

        #region Lighting.Sampler.SamplerA

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.OffStyle);

        #region Lighting.Sampler.SamplerA.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourThree);

        #endregion

        #endregion

        #region Lighting.Sampler.SamplerB

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.OffStyle);

        #region Lighting.Sampler.SamplerB.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourThree);

        #endregion

        #endregion

        #region Lighting.Sampler.SamplerC

        Assert.Equal(LightingOffStyle.Dimmed, _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.OffStyle);

        #region Lighting.Sampler.SamplerC.Colour

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourOne);
        Assert.Equal("202020", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourTwo);
        Assert.Equal("303030", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourThree);

        #endregion

        #endregion

        #endregion

        #region Lighting.Simple

        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Accent.ColourOne);
        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Global.ColourOne);
        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Scribble1.ColourOne);
        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Scribble2.ColourOne);
        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Scribble3.ColourOne);
        Assert.Equal("101010", _messageHandler.Status.Mixers["SerialNumber"].Lighting.Simple.Scribble4.ColourOne);

        #endregion

        #endregion

        #region MicStatus

        Assert.Equal(MicrophoneType.Condenser, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.MicType);

        #region MicStatus.Compressor

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Compressor.Attack);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Compressor.MakeUpGain);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Compressor.Ratio);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Compressor.Release);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Compressor.Threshold);

        #endregion

        #region MicStatus.Equaliser

        #region MicStatus.Equaliser.Gain

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer31Hz);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer63Hz);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer125Hz);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer250Hz);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer500Hz);
        Assert.Equal(16, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer1KHz);
        Assert.Equal(17, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer2KHz);
        Assert.Equal(18, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer4KHz);
        Assert.Equal(19, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer8KHz);
        Assert.Equal(20, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer16KHz);

        #endregion

        #region MicStatus.Equaliser.Frequency

        Assert.Equal(11.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer31Hz);
        Assert.Equal(12.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer63Hz);
        Assert.Equal(13.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer125Hz);
        Assert.Equal(14.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer250Hz);
        Assert.Equal(15.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer500Hz);
        Assert.Equal(16.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer1KHz);
        Assert.Equal(17.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer2KHz);
        Assert.Equal(18.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer4KHz);
        Assert.Equal(19.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer8KHz);
        Assert.Equal(20.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer16KHz);

        #endregion

        #endregion

        #region MicStatus.EqualiserMini

        #region MicStatus.EqualiserMini.GainMini

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer90Hz);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer250Hz);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer500Hz);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer1KHz);
        Assert.Equal(15, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer3KHz);
        Assert.Equal(16, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer8KHz);

        #endregion

        #region MicStatus.EqualiserMini.FrequencyMini

        Assert.Equal(11.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer90Hz);
        Assert.Equal(12.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer250Hz);
        Assert.Equal(13.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer500Hz);
        Assert.Equal(14.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer1KHz);
        Assert.Equal(15.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer3KHz);
        Assert.Equal(16.0, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer8KHz);

        #endregion

        #endregion

        #region MicStatus.MicGains

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.MicGains.Condenser);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.MicGains.Dynamic);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.MicGains.Jack);

        #endregion

        #region MicStatus.NoiseGate

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.NoiseGate.Attack);
        Assert.Equal(12, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.NoiseGate.Attenuation);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].MicStatus.NoiseGate.Enabled);
        Assert.Equal(13, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.NoiseGate.Release);
        Assert.Equal(14, _messageHandler.Status.Mixers["SerialNumber"].MicStatus.NoiseGate.Threshold);

        #endregion

        #endregion

        #region Router

        #region Router.Chat

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Chat.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Chat.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Chat.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Chat.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Chat.Sampler);

        #endregion

        #region Router.Console

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Console.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Console.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Console.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Console.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Console.Sampler);

        #endregion

        #region Router.Game

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Game.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Game.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Game.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Game.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Game.Sampler);

        #endregion

        #region Router.LineIn

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.LineIn.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.LineIn.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.LineIn.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.LineIn.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.LineIn.Sampler);

        #endregion

        #region Router.Microphone

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Microphone.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Microphone.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Microphone.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Microphone.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Microphone.Sampler);

        #endregion

        #region Router.Music

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Music.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Music.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Music.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Music.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Music.Sampler);

        #endregion

        #region Router.Samples

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Samples.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Samples.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Samples.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Samples.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.Samples.Sampler);

        #endregion

        #region Router.System

        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.System.BroadcastMix);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.System.ChatMic);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.System.Headphones);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.System.LineOut);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Router.System.Sampler);

        #endregion

        #endregion

        #region Sampler

        var sample = new Sample
        {
            Name = "tree.wav",
            StartPct = 10.10,
            StopPct = 90.90
        };

        var sample2 = new Sample
        {
            Name = "098.wav",
            StartPct = 0.0,
            StopPct = 100.0
        };

        var sample3 = new Sample
        {
            Name = "567.wav",
            StartPct = 0.0,
            StopPct = 100.0
        };

        #region Sampler.SamplerBanks

        #region Sampler.SamplerBanks.SamplerBankA

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.BottomRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.TopLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.TopRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples[2]);

        #endregion

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.BottomRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.TopLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.TopRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples[2]);

        #endregion

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.BottomRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.TopLeft

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples[2]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.TopRight

        Assert.Equal(SamplePlaybackMode.Loop, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Function);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Random, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples.Count);
        Assert.Equal(sample, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples[0]);
        Assert.Equal(sample2, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples[1]);
        Assert.Equal(sample3, _messageHandler.Status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples[2]);

        #endregion

        #endregion

        #endregion

        #endregion

        #endregion

        #region Settings

        Assert.Equal(11, _messageHandler.Status.Mixers["SerialNumber"].Settings.MuteHoldDuration);
        Assert.False(_messageHandler.Status.Mixers["SerialNumber"].Settings.VcMuteAlsoMuteCm);

        #region Settings.Display

        Assert.Equal(DisplayMode.Simple, _messageHandler.Status.Mixers["SerialNumber"].Settings.Display.Compressor);
        Assert.Equal(DisplayMode.Simple, _messageHandler.Status.Mixers["SerialNumber"].Settings.Display.Equaliser);
        Assert.Equal(DisplayMode.Advanced, _messageHandler.Status.Mixers["SerialNumber"].Settings.Display.EqualiserFine);
        Assert.Equal(DisplayMode.Simple, _messageHandler.Status.Mixers["SerialNumber"].Settings.Display.Gate);

        #endregion

        #endregion

        #endregion

        #region Files

        Assert.Equal(2, _messageHandler.Status.Files.Icons.Count);
        Assert.Equal("phone.png", _messageHandler.Status.Files.Icons[0]);
        Assert.Equal("wood.png", _messageHandler.Status.Files.Icons[1]);

        Assert.Equal(2, _messageHandler.Status.Files.MicProfiles.Count);
        Assert.Equal("phone.png", _messageHandler.Status.Files.MicProfiles[0]);
        Assert.Equal("wood.png", _messageHandler.Status.Files.MicProfiles[1]);

        Assert.Equal(2, _messageHandler.Status.Files.Presets.Count);
        Assert.Equal("phone.png", _messageHandler.Status.Files.Presets[0]);
        Assert.Equal("wood.png", _messageHandler.Status.Files.Presets[1]);

        Assert.Equal(2, _messageHandler.Status.Files.Profiles.Count);
        Assert.Equal("phone.png", _messageHandler.Status.Files.Profiles[0]);
        Assert.Equal("wood.png", _messageHandler.Status.Files.Profiles[1]);

        Assert.Equal(2, _messageHandler.Status.Files.Samples.Count);
        Assert.Equal("phone.png", _messageHandler.Status.Files.Samples["1\\phone.png"]);
        Assert.Equal("tree.png", _messageHandler.Status.Files.Samples["2\\tree.png"]);

        #endregion

        #region Paths

        Assert.Equal("1", _messageHandler.Status.Paths.IconsDirectory);
        Assert.Equal("2", _messageHandler.Status.Paths.MicProfileDirectory);
        Assert.Equal("3", _messageHandler.Status.Paths.PresetsDirectory);
        Assert.Equal("4", _messageHandler.Status.Paths.ProfileDirectory);
        Assert.Equal("5", _messageHandler.Status.Paths.SamplesDirectory);

        #endregion

        _messageHandler.HandleMessage(_smallPatchString);
    }
}