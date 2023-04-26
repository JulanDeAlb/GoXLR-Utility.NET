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
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels.Submix;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.Status;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.Tests;

public class JsonDeserializeTest
{
    private readonly string _statusString;
    private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
    {
        Converters = { new JsonStringEnumConverter() }
    };

    public JsonDeserializeTest()
    {
        const string resourceName = "GoXLR_Utility.NET.Tests.EmbeddedResources.Status.json";
        var assembly = Assembly.GetExecutingAssembly();

        using var stream = assembly.GetManifestResourceStream(resourceName);
        using var reader = new StreamReader(stream!);
        _statusString = reader.ReadToEnd();
    }

    [Fact]
    public void DeserializeStatus()
    {
        //For now i manually test every Value, will be rewritten with Utility saving overhaul in 2.0

        Status? status = null;
        var exception = Record.Exception(() =>
        {
            status = JsonSerializer.Deserialize<Response>(_statusString, _serializerOptions)?.Data?.Status;
        });

        Assert.Null(exception);
        Assert.NotNull(status);

        #region Config

        Assert.Equal("0.9.0", status.Config.DaemonVersion);
        Assert.True(status.Config.AutostartEnabled);
        Assert.True(status.Config.ShowTrayIcon);
        Assert.True(status.Config.TextToSpeechEnabled);

        #endregion

        #region Device

        Assert.Equal("DEFAULT", status.Mixers["SerialNumber"].MicProfileName);
        Assert.Equal("Main", status.Mixers["SerialNumber"].ProfileName);

        #region ButtonDown

        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Bleep);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Cough);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectFx);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectHardTune);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectMegaphone);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectRobot);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect1);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect2);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect3);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect4);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect5);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect6);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader1Mute);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader2Mute);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader3Mute);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader4Mute);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerClear);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectA);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectB);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectC);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerBottomLeft);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerBottomRight);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerTopLeft);
        Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerTopRight);

        #endregion

        #region CoughButton

        Assert.True(status.Mixers["SerialNumber"].CoughButton.IsToggle);
        Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].CoughButton.MuteFunction);
        Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].CoughButton.MuteState);

        #endregion

        #region Effects

        Assert.Equal(EffectBankPresets.Preset6, status.Mixers["SerialNumber"].Effects.ActivePreset);
        Assert.True(status.Mixers["SerialNumber"].Effects.IsEnabled);

        #region Effects.Current.Echo

        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Echo.Amount);
        Assert.Equal(110, status.Mixers["SerialNumber"].Effects.Current.Echo.DelayLeft);
        Assert.Equal(120, status.Mixers["SerialNumber"].Effects.Current.Echo.DelayRight);
        Assert.Equal(11, status.Mixers["SerialNumber"].Effects.Current.Echo.Feedback);
        Assert.Equal(60, status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackLeft);
        Assert.Equal(50, status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackRight);
        Assert.Equal(3, status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackXfbRtL);
        Assert.Equal(2, status.Mixers["SerialNumber"].Effects.Current.Echo.FeedbackXfbLtR);
        Assert.Equal(EchoStyle.ClassicSlap , status.Mixers["SerialNumber"].Effects.Current.Echo.Style);
        Assert.Equal(120, status.Mixers["SerialNumber"].Effects.Current.Echo.Tempo);

        #region Effects.Current.Gender

        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Gender.Amount);
        Assert.Equal(GenderStyle.Medium , status.Mixers["SerialNumber"].Effects.Current.Gender.Style);

        #endregion

        #region Effects.Current.HardTune

        Assert.Equal(53, status.Mixers["SerialNumber"].Effects.Current.HardTune.Amount);
        Assert.True(status.Mixers["SerialNumber"].Effects.Current.HardTune.IsEnabled);
        Assert.Equal(99, status.Mixers["SerialNumber"].Effects.Current.HardTune.Rate);
        Assert.Equal(HardTuneSource.All, status.Mixers["SerialNumber"].Effects.Current.HardTune.Source);
        Assert.Equal(HardTuneStyle.Medium , status.Mixers["SerialNumber"].Effects.Current.HardTune.Style);
        Assert.Equal(20, status.Mixers["SerialNumber"].Effects.Current.HardTune.Window);

        #endregion

        #region Effects.Current.Megaphone

        Assert.Equal(30, status.Mixers["SerialNumber"].Effects.Current.Megaphone.Amount);
        Assert.True(status.Mixers["SerialNumber"].Effects.Current.Megaphone.IsEnabled);
        Assert.Equal(2, status.Mixers["SerialNumber"].Effects.Current.Megaphone.PostGain);
        Assert.Equal(MegaphoneStyle.Radio , status.Mixers["SerialNumber"].Effects.Current.Megaphone.Style);

        #endregion

        #region Effects.Current.Pitch

        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Pitch.Amount);
        Assert.Equal(75, status.Mixers["SerialNumber"].Effects.Current.Pitch.Character);
        Assert.Equal(PitchStyle.Wide , status.Mixers["SerialNumber"].Effects.Current.Pitch.Style);

        #endregion

        #region Effects.Current.Reverb

        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Reverb.Amount);
        Assert.Equal(30, status.Mixers["SerialNumber"].Effects.Current.Reverb.Decay);
        Assert.Equal(43, status.Mixers["SerialNumber"].Effects.Current.Reverb.Diffuse);
        Assert.Equal(2, status.Mixers["SerialNumber"].Effects.Current.Reverb.EarlyLevel);
        Assert.Equal(26, status.Mixers["SerialNumber"].Effects.Current.Reverb.HiColour);
        Assert.Equal(16, status.Mixers["SerialNumber"].Effects.Current.Reverb.HiFactor);
        Assert.Equal(-27, status.Mixers["SerialNumber"].Effects.Current.Reverb.LoColour);
        Assert.Equal(8, status.Mixers["SerialNumber"].Effects.Current.Reverb.ModDepth);
        Assert.Equal(21, status.Mixers["SerialNumber"].Effects.Current.Reverb.ModSpeed);
        Assert.Equal(100, status.Mixers["SerialNumber"].Effects.Current.Reverb.PreDelay);
        Assert.Equal(ReverbStyle.RealPlate , status.Mixers["SerialNumber"].Effects.Current.Reverb.Style);
        Assert.Equal(3, status.Mixers["SerialNumber"].Effects.Current.Reverb.TailLevel);

        #endregion

        #region Effects.Current.Robot

        Assert.Equal(-6, status.Mixers["SerialNumber"].Effects.Current.Robot.DryMix);
        Assert.True(status.Mixers["SerialNumber"].Effects.Current.Robot.IsEnabled);
        Assert.Equal(240, status.Mixers["SerialNumber"].Effects.Current.Robot.HighFreq);
        Assert.Equal(12, status.Mixers["SerialNumber"].Effects.Current.Robot.HighGain);
        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Robot.HighWidth);
        Assert.Equal(87, status.Mixers["SerialNumber"].Effects.Current.Robot.LowFreq);
        Assert.Equal(3, status.Mixers["SerialNumber"].Effects.Current.Robot.LowGain);
        Assert.Equal(32, status.Mixers["SerialNumber"].Effects.Current.Robot.LowWidth);
        Assert.Equal(155, status.Mixers["SerialNumber"].Effects.Current.Robot.MidFreq);
        Assert.Equal(-2, status.Mixers["SerialNumber"].Effects.Current.Robot.MidGain);
        Assert.Equal(23, status.Mixers["SerialNumber"].Effects.Current.Robot.MidWidth);
        Assert.Equal(50, status.Mixers["SerialNumber"].Effects.Current.Robot.PulseWidth);
        Assert.Equal(RobotStyle.Robot2, status.Mixers["SerialNumber"].Effects.Current.Robot.Style);
        Assert.Equal(-36, status.Mixers["SerialNumber"].Effects.Current.Robot.Threshold);
        Assert.Equal(1, status.Mixers["SerialNumber"].Effects.Current.Robot.WaveFrom);

        #endregion

        #endregion

        #region Effects.PresetNames

        Assert.Equal("Big Verb", status.Mixers["SerialNumber"].Effects.PresetNames.Preset1);
        Assert.Equal("Comms Radio", status.Mixers["SerialNumber"].Effects.PresetNames.Preset2);
        Assert.Equal("HardTune Music", status.Mixers["SerialNumber"].Effects.PresetNames.Preset3);
        Assert.Equal("Kid Robot", status.Mixers["SerialNumber"].Effects.PresetNames.Preset4);
        Assert.Equal("PitchDn Echo", status.Mixers["SerialNumber"].Effects.PresetNames.Preset5);
        Assert.Equal("BadMic", status.Mixers["SerialNumber"].Effects.PresetNames.Preset6);

        #endregion

        #endregion

        #region FaderStatus

        #region FaderStatus.FaderA

        Assert.Equal(ChannelName.Chat, status.Mixers["SerialNumber"].FaderStatus.FaderA.Channel);
        Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].FaderStatus.FaderA.MuteType);
        Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].FaderStatus.FaderA.MuteState);


        #region FaderStatus.FaderA.Scribble

        Assert.Equal("Voice Chat", status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.BottomText);
        Assert.Equal("person.png", status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.FileName);
        Assert.True(status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.Inverted);
        Assert.Equal("1", status.Mixers["SerialNumber"].FaderStatus.FaderA.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderB

        Assert.Equal(ChannelName.Game, status.Mixers["SerialNumber"].FaderStatus.FaderB.Channel);
        Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].FaderStatus.FaderB.MuteType);
        Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].FaderStatus.FaderB.MuteState);


        #region FaderStatus.FaderB.Scribble

        Assert.Equal("Browser", status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.BottomText);
        Assert.Equal("scale.png", status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.FileName);
        Assert.True(status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.Inverted);
        Assert.Equal("2", status.Mixers["SerialNumber"].FaderStatus.FaderB.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderC

        Assert.Equal(ChannelName.System, status.Mixers["SerialNumber"].FaderStatus.FaderC.Channel);
        Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].FaderStatus.FaderC.MuteType);
        Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].FaderStatus.FaderC.MuteState);


        #region FaderStatus.FaderC.Scribble

        Assert.Equal("System", status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.BottomText);
        Assert.Equal("level.png", status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.FileName);
        Assert.True(status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.Inverted);
        Assert.Equal("3", status.Mixers["SerialNumber"].FaderStatus.FaderC.Scribble.LeftText);

        #endregion

        #endregion

        #region FaderStatus.FaderD

        Assert.Equal(ChannelName.Music, status.Mixers["SerialNumber"].FaderStatus.FaderD.Channel);
        Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].FaderStatus.FaderD.MuteType);
        Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].FaderStatus.FaderD.MuteState);


        #region FaderStatus.FaderD.Scribble

        Assert.Equal("Music", status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.BottomText);
        Assert.Equal("music.png", status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.FileName);
        Assert.True(status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.Inverted);
        Assert.Equal("4", status.Mixers["SerialNumber"].FaderStatus.FaderD.Scribble.LeftText);

        #endregion

        #endregion

        #endregion

        #region Hardware

        Assert.Equal("Full", status.Mixers["SerialNumber"].Hardware.DeviceType);
        Assert.Equal(DateTimeOffset.Parse("2020-06-23"), status.Mixers["SerialNumber"].Hardware.ManufacturedDate);
        Assert.Equal("SerialNumber", status.Mixers["SerialNumber"].Hardware.SerialNumber);

        #region Hardware.UsbDevice

        Assert.Equal(2, status.Mixers["SerialNumber"].Hardware.UsbDevice.Address);
        Assert.Equal(1, status.Mixers["SerialNumber"].Hardware.UsbDevice.BusNumber);
        Assert.Equal("USB\\Anything\\Anything", status.Mixers["SerialNumber"].Hardware.UsbDevice.Identifier);
        Assert.Equal("TC-Helicon", status.Mixers["SerialNumber"].Hardware.UsbDevice.ManufacturerName);
        Assert.Equal("GoXLR", status.Mixers["SerialNumber"].Hardware.UsbDevice.ProductName);

        Assert.Equal(3, status.Mixers["SerialNumber"].Hardware.UsbDevice.Version.Count);
        Assert.Equal(2, status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[0]);
        Assert.Equal(1, status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[1]);
        Assert.Equal(3, status.Mixers["SerialNumber"].Hardware.UsbDevice.Version[2]);

        #endregion

        #region Hardware.Versions

        Assert.Equal(4, status.Mixers["SerialNumber"].Hardware.Versions.Dice.Count);
        Assert.Equal(1, status.Mixers["SerialNumber"].Hardware.Versions.Dice[0]);
        Assert.Equal(3, status.Mixers["SerialNumber"].Hardware.Versions.Dice[1]);
        Assert.Equal(9, status.Mixers["SerialNumber"].Hardware.Versions.Dice[2]);
        Assert.Equal(100, status.Mixers["SerialNumber"].Hardware.Versions.Dice[3]);

        Assert.Equal(4, status.Mixers["SerialNumber"].Hardware.Versions.Firmware.Count);
        Assert.Equal(1, status.Mixers["SerialNumber"].Hardware.Versions.Firmware[0]);
        Assert.Equal(3, status.Mixers["SerialNumber"].Hardware.Versions.Firmware[1]);
        Assert.Equal(44, status.Mixers["SerialNumber"].Hardware.Versions.Firmware[2]);
        Assert.Equal(106, status.Mixers["SerialNumber"].Hardware.Versions.Firmware[3]);

        Assert.Equal(7, status.Mixers["SerialNumber"].Hardware.Versions.FpgaCount);

        #endregion

        #endregion

        #region Levels
        
        Assert.Equal(-10, status.Mixers["SerialNumber"].Levels.Bleep);
        Assert.Equal(70, status.Mixers["SerialNumber"].Levels.DeEsser);
        Assert.True(status.Mixers["SerialNumber"].Levels.SubmixSupported);
        
        #region Levels.Submix
        
        #region Levels.Submix.Inputs

        #region Levels.Submix.Inputs.Chat

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Chat.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Chat.Ratio);
        Assert.Equal(164, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Chat.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.Console

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Console.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Console.Ratio);
        Assert.Equal(70, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Console.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.Game

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Game.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Game.Ratio);
        Assert.Equal(155, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Game.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.LineIn

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.LineIn.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.LineIn.Ratio);
        Assert.Equal(128, status.Mixers["SerialNumber"].Levels.Submix.Inputs.LineIn.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.Mic

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Mic.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Mic.Ratio);
        Assert.Equal(255, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Mic.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.Music

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Music.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Music.Ratio);
        Assert.Equal(89, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Music.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.Sample

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.Sample.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Sample.Ratio);
        Assert.Equal(166, status.Mixers["SerialNumber"].Levels.Submix.Inputs.Sample.Volume);

        #endregion
        
        #region Levels.Submix.Inputs.System

        Assert.True(status.Mixers["SerialNumber"].Levels.Submix.Inputs.System.Linked);
        Assert.Equal(1.0, status.Mixers["SerialNumber"].Levels.Submix.Inputs.System.Ratio);
        Assert.Equal(128, status.Mixers["SerialNumber"].Levels.Submix.Inputs.System.Volume);

        #endregion

        #endregion
        
        #region Levels.Submix.Outputs

        Assert.Equal(SubmixOutput.A ,status.Mixers["SerialNumber"].Levels.Submix.Outputs.BroadcastMix);
        Assert.Equal(SubmixOutput.A ,status.Mixers["SerialNumber"].Levels.Submix.Outputs.ChatMic);
        Assert.Equal(SubmixOutput.A ,status.Mixers["SerialNumber"].Levels.Submix.Outputs.Headphone);
        Assert.Equal(SubmixOutput.A ,status.Mixers["SerialNumber"].Levels.Submix.Outputs.LineOut);
        Assert.Equal(SubmixOutput.B ,status.Mixers["SerialNumber"].Levels.Submix.Outputs.Sampler);

        #endregion

        #endregion

        #region Levels.Volume

        Assert.Equal(165, status.Mixers["SerialNumber"].Levels.Volumes.Chat);
        Assert.Equal(128, status.Mixers["SerialNumber"].Levels.Volumes.Console);
        Assert.Equal(153, status.Mixers["SerialNumber"].Levels.Volumes.Game);
        Assert.Equal(204, status.Mixers["SerialNumber"].Levels.Volumes.Headphones);
        Assert.Equal(128, status.Mixers["SerialNumber"].Levels.Volumes.LineIn);
        Assert.Equal(255, status.Mixers["SerialNumber"].Levels.Volumes.LineOut);
        Assert.Equal(255, status.Mixers["SerialNumber"].Levels.Volumes.Mic);
        Assert.Equal(204, status.Mixers["SerialNumber"].Levels.Volumes.MicMonitor);
        Assert.Equal(150, status.Mixers["SerialNumber"].Levels.Volumes.Music);
        Assert.Equal(166, status.Mixers["SerialNumber"].Levels.Volumes.Sample);
        Assert.Equal(128, status.Mixers["SerialNumber"].Levels.Volumes.System);

        #endregion

        #endregion

        #region Lighting

        #region Lighting.Button

        #region Lighting.Button.Bleep

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.Bleep.OffStyle);

        #region Lighting.Button.Bleep.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.Bleep.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.Bleep.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.Cough

        Assert.Equal(LightingOffStyle.Dimmed, status.Mixers["SerialNumber"].Lighting.Button.Cough.OffStyle);

        #region Lighting.Button.Cough.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.Cough.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.Cough.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectFx

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectFx.OffStyle);

        #region Lighting.Button.EffectFx.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectFx.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectFx.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectHardTune

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.OffStyle);

        #region Lighting.Button.EffectHardTune.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectHardTune.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectMegaphone

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.OffStyle);

        #region Lighting.Button.EffectMegaphone.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectMegaphone.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectRobot

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.OffStyle);

        #region Lighting.Button.EffectRobot.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectRobot.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect1

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.OffStyle);

        #region Lighting.Button.EffectSelect1.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect1.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect2

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.OffStyle);

        #region Lighting.Button.EffectSelect2.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect2.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect3

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.OffStyle);

        #region Lighting.Button.EffectSelect3.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect3.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect4

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.OffStyle);

        #region Lighting.Button.EffectSelect4.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect4.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect5

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.OffStyle);

        #region Lighting.Button.EffectSelect5.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect5.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.EffectSelect6

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.OffStyle);

        #region Lighting.Button.EffectSelect6.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.EffectSelect6.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderAMute

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.OffStyle);

        #region Lighting.Button.FaderAMute.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.FaderAMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderBMute

        Assert.Equal(LightingOffStyle.DimmedColour2, status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.OffStyle);

        #region Lighting.Button.FaderBMute.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.FaderBMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderCMute

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.OffStyle);

        #region Lighting.Button.FaderCMute.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.FaderCMute.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Button.FaderDMute

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.OffStyle);

        #region Lighting.Button.FaderDMute.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Button.FaderDMute.Colour.ColourTwo);

        #endregion

        #endregion

        #endregion

        #region Lighting.Encoder

        #region Lighting.Encoder.Echo

        Assert.Equal("000000", status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourTwo);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Encoder.Echo.ColourThree);

        #endregion

        #region Lighting.Encoder.Gender

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourTwo);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Encoder.Gender.ColourThree);

        #endregion

        #region Lighting.Encoder.Pitch

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourTwo);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Encoder.Pitch.ColourThree);

        #endregion

        #region Lighting.Encoder.Reverb

        Assert.Equal("000000", status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourTwo);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Encoder.Reverb.ColourThree);

        #endregion

        #endregion

        #region Lighting.Fader

        #region Lighting.Fader.FaderA

        Assert.Equal(FaderDisplayStyle.Gradient, status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Style);

        #region Lighting.Fader.FaderA.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Fader.FaderA.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderB

        Assert.Equal(FaderDisplayStyle.Gradient, status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Style);

        #region Lighting.Fader.FaderB.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Fader.FaderB.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderC

        Assert.Equal(FaderDisplayStyle.Gradient, status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Style);

        #region Lighting.Fader.FaderC.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Fader.FaderC.Colour.ColourTwo);

        #endregion

        #endregion

        #region Lighting.Fader.FaderD

        Assert.Equal(FaderDisplayStyle.Gradient, status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Style);

        #region Lighting.Fader.FaderD.Colour

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Colour.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Fader.FaderD.Colour.ColourTwo);

        #endregion

        #endregion

        #endregion

        #region Lighting.Sampler

        #region Lighting.Sampler.SamplerA

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.OffStyle);

        #region Lighting.Sampler.SamplerA.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourTwo);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerA.Colour.ColourThree);

        #endregion

        #endregion

        #region Lighting.Sampler.SamplerB

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.OffStyle);

        #region Lighting.Sampler.SamplerB.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourTwo);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerB.Colour.ColourThree);

        #endregion

        #endregion

        #region Lighting.Sampler.SamplerC

        Assert.Equal(LightingOffStyle.Colour2, status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.OffStyle);

        #region Lighting.Sampler.SamplerC.Colour

        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourTwo);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Sampler.SamplerC.Colour.ColourThree);

        #endregion

        #endregion

        #endregion

        #region Lighting.Simple

        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Simple.Accent.ColourOne);
        Assert.Equal("00FFFF", status.Mixers["SerialNumber"].Lighting.Simple.Global.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Simple.Scribble1.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Simple.Scribble2.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Simple.Scribble3.ColourOne);
        Assert.Equal("25FF00", status.Mixers["SerialNumber"].Lighting.Simple.Scribble4.ColourOne);

        #endregion

        #endregion

        #region MicStatus

        Assert.Equal(MicrophoneType.Dynamic, status.Mixers["SerialNumber"].MicStatus.MicType);

        #region MicStatus.Compressor

        Assert.Equal(4, status.Mixers["SerialNumber"].MicStatus.Compressor.Attack);
        Assert.Equal(2, status.Mixers["SerialNumber"].MicStatus.Compressor.MakeUpGain);
        Assert.Equal(9, status.Mixers["SerialNumber"].MicStatus.Compressor.Ratio);
        Assert.Equal(4, status.Mixers["SerialNumber"].MicStatus.Compressor.Release);
        Assert.Equal(-22, status.Mixers["SerialNumber"].MicStatus.Compressor.Threshold);

        #endregion

        #region MicStatus.Equaliser

        #region MicStatus.Equaliser.Gain

        Assert.Equal(-2, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer31Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer63Hz);
        Assert.Equal(2, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer125Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer250Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer500Hz);
        Assert.Equal(-1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer1KHz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer2KHz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer4KHz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer8KHz);
        Assert.Equal(2, status.Mixers["SerialNumber"].MicStatus.Equaliser.Gain.Equalizer16KHz);

        #endregion

        #region MicStatus.Equaliser.Frequency

        Assert.Equal(31.5, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer31Hz);
        Assert.Equal(63.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer63Hz);
        Assert.Equal(125.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer125Hz);
        Assert.Equal(250.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer250Hz);
        Assert.Equal(500.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer500Hz);
        Assert.Equal(1000.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer1KHz);
        Assert.Equal(2000.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer2KHz);
        Assert.Equal(4000.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer4KHz);
        Assert.Equal(8000.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer8KHz);
        Assert.Equal(16000.0, status.Mixers["SerialNumber"].MicStatus.Equaliser.Frequency.Equalizer16KHz);

        #endregion

        #endregion

        #region MicStatus.EqualiserMini

        #region MicStatus.EqualiserMini.GainMini

        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer90Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer250Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer500Hz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer1KHz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer3KHz);
        Assert.Equal(1, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Gain.Equalizer8KHz);

        #endregion

        #region MicStatus.EqualiserMini.FrequencyMini

        Assert.Equal(90.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer90Hz);
        Assert.Equal(250.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer250Hz);
        Assert.Equal(500.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer500Hz);
        Assert.Equal(1000.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer1KHz);
        Assert.Equal(3000.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer3KHz);
        Assert.Equal(8000.0, status.Mixers["SerialNumber"].MicStatus.EqualiserMini.Frequency.Equalizer8KHz);

        #endregion

        #endregion

        #region MicStatus.MicGains

        Assert.Equal(30, status.Mixers["SerialNumber"].MicStatus.MicGains.Condenser);
        Assert.Equal(60, status.Mixers["SerialNumber"].MicStatus.MicGains.Dynamic);
        Assert.Equal(30, status.Mixers["SerialNumber"].MicStatus.MicGains.Jack);

        #endregion

        #region MicStatus.NoiseGate

        Assert.Equal(20, status.Mixers["SerialNumber"].MicStatus.NoiseGate.Attack);
        Assert.Equal(100, status.Mixers["SerialNumber"].MicStatus.NoiseGate.Attenuation);
        Assert.True(status.Mixers["SerialNumber"].MicStatus.NoiseGate.Enabled);
        Assert.Equal(44, status.Mixers["SerialNumber"].MicStatus.NoiseGate.Release);
        Assert.Equal(-32, status.Mixers["SerialNumber"].MicStatus.NoiseGate.Threshold);

        #endregion

        #endregion

        #region Router

        #region Router.Chat

        Assert.True(status.Mixers["SerialNumber"].Router.Chat.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Chat.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Chat.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Chat.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Chat.Sampler);

        #endregion

        #region Router.Console

        Assert.True(status.Mixers["SerialNumber"].Router.Console.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Console.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Console.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Console.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Console.Sampler);

        #endregion

        #region Router.Game

        Assert.True(status.Mixers["SerialNumber"].Router.Game.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Game.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Game.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Game.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Game.Sampler);

        #endregion

        #region Router.LineIn

        Assert.True(status.Mixers["SerialNumber"].Router.LineIn.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.LineIn.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.LineIn.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.LineIn.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.LineIn.Sampler);

        #endregion

        #region Router.Microphone

        Assert.True(status.Mixers["SerialNumber"].Router.Microphone.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Microphone.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Microphone.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Microphone.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Microphone.Sampler);

        #endregion

        #region Router.Music

        Assert.True(status.Mixers["SerialNumber"].Router.Music.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Music.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Music.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Music.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Music.Sampler);

        #endregion

        #region Router.Samples

        Assert.True(status.Mixers["SerialNumber"].Router.Samples.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.Samples.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.Samples.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.Samples.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.Samples.Sampler);

        #endregion

        #region Router.System

        Assert.True(status.Mixers["SerialNumber"].Router.System.BroadcastMix);
        Assert.True(status.Mixers["SerialNumber"].Router.System.ChatMic);
        Assert.True(status.Mixers["SerialNumber"].Router.System.Headphones);
        Assert.True(status.Mixers["SerialNumber"].Router.System.LineOut);
        Assert.True(status.Mixers["SerialNumber"].Router.System.Sampler);

        #endregion

        #endregion

        #region Sampler

        var sample = new Sample
        {
            Name = "123.wav",
            StartPct = 17.2185,
            StopPct = 100.0
        };

        var sample2 = new Sample
        {
            Name = "234.wav",
            StartPct = 17.2185,
            StopPct = 100.0
        };

        #region Sampler.SamplerBanks

        #region Sampler.SamplerBanks.SamplerBankA

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.BottomRight

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.BottomRight.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.TopLeft

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankA.TopRight

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples[1]);

        #endregion

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.BottomRight

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.BottomRight.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.TopLeft

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankB.TopRight

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples[1]);

        #endregion

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.BottomRight

        Assert.Equal(SamplePlaybackMode.PlayNext, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.BottomRight.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.TopLeft

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples[1]);

        #endregion

        #endregion

        #region Sampler.SamplerBanks.SamplerBankC.TopRight

        Assert.Equal(SamplePlaybackMode.PlayStop, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Function);
        Assert.True(status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.IsPlaying);
        Assert.Equal(SamplePlayOrder.Sequential, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Order);

        #region Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples

        Assert.Equal(2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples.Count);
        Assert.Equal(sample, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples[0]);
        Assert.Equal(sample2, status.Mixers["SerialNumber"].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples[1]);

        #endregion

        #endregion

        #endregion

        #endregion

        #endregion

        #region Settings

        Assert.Equal(500, status.Mixers["SerialNumber"].Settings.MuteHoldDuration);
        Assert.True(status.Mixers["SerialNumber"].Settings.VcMuteAlsoMuteCm);

        #region Settings.Display

        Assert.Equal(DisplayMode.Advanced, status.Mixers["SerialNumber"].Settings.Display.Compressor);
        Assert.Equal(DisplayMode.Advanced, status.Mixers["SerialNumber"].Settings.Display.Equaliser);
        Assert.Equal(DisplayMode.Simple, status.Mixers["SerialNumber"].Settings.Display.EqualiserFine);
        Assert.Equal(DisplayMode.Advanced, status.Mixers["SerialNumber"].Settings.Display.Gate);

        #endregion

        #endregion
        
        #region ShutdownCommands

        Assert.Equal(
            "{\"SaveProfile\":[]}",
            status.Mixers["SerialNumber"].ShutdownCommands[0].ToString()?.Replace(" ", "").Replace("\r\n", ""));
        Assert.Equal(
            "{\"SaveMicProfile\":[]}",
            status.Mixers["SerialNumber"].ShutdownCommands[1].ToString()?.Replace(" ", "").Replace("\r\n", ""));
        Assert.Equal(
            "{\"LoadProfileColours\":\"Main\"}",
            status.Mixers["SerialNumber"].ShutdownCommands[2].ToString()?.Replace(" ", "").Replace("\r\n", ""));

        #endregion

        #endregion

        #region Paths

        Assert.Equal("C:\\Users\\profiles", status.Paths.ProfileDirectory);
        Assert.Equal("C:\\Users\\mic-profiles", status.Paths.MicProfileDirectory);
        Assert.Equal("C:\\Users\\samples", status.Paths.SamplesDirectory);
        Assert.Equal("C:\\Users\\presets", status.Paths.PresetsDirectory);
        Assert.Equal("C:\\Users\\icons", status.Paths.IconsDirectory);

        #endregion

        #region Files

        Assert.Equal("Main", status.Files.Profiles[0]);
        Assert.Equal("DEFAULT", status.Files.MicProfiles[0]);
        Assert.Equal("BadMic", status.Files.Presets[0]);
        Assert.Equal("123.wav", status.Files.Samples["Recorded\\123.wav"]);
        Assert.Equal("headphone.png", status.Files.Icons[0]);

        #endregion
    }
}