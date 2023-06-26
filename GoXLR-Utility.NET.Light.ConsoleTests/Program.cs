﻿using GoXLR_Utility.NET.Commands;
using GoXLR_Utility.NET.Commands.Mixer.ButtonDown;
using GoXLR_Utility.NET.Commands.Mixer.CoughButton;
using GoXLR_Utility.NET.Commands.Mixer.Effects;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Echo;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Gender;
using GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb;
using GoXLR_Utility.NET.Commands.Mixer.Effects.Robot;
using GoXLR_Utility.NET.Commands.Mixer.FaderStatus;
using GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Commands.Mixer.Levels;
using GoXLR_Utility.NET.Commands.Mixer.Levels.Submix;
using GoXLR_Utility.NET.Commands.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.Commands.Mixer.MicStatus;
using GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Commands.Mixer.Profile.Mic;
using GoXLR_Utility.NET.Commands.Mixer.Profile.Normal;
using GoXLR_Utility.NET.Commands.Mixer.Router;
using GoXLR_Utility.NET.Commands.Mixer.Sampler;
using GoXLR_Utility.NET.Commands.Mixer.Settings;
using GoXLR_Utility.NET.Commands.Mixer.Settings.Display;
using GoXLR_Utility.NET.Commands.Mixer.ShutdownCommands;
using GoXLR_Utility.NET.Enums.Commands;
using GoXLR_Utility.NET.Enums.Response.Status.Config;
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
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Light.ConsoleTests;

public static class Program
{
    private static Logger _log = new();
    private static readonly Utility Utility = new();

    public static void Main(string[] args)
    {
        //Utility.Connect("ws://localhost:14564/api/websocket");
        Utility.Connect();
        Utility.OnPatch += (_, patch) => Console.WriteLine(patch.ToString());
        Console.ReadKey();
        AllCommands(Utility.AvailableSerialNumbers[0]);
        Console.ReadKey();
    }

    private static void AllCommands(string serialNumber)
    {
        #region NormalCommands

        #region NormalCommands.RecoverDefaults

        Utility.SendCommand(new RecoverDefaults(Defaults.Icons));
        Task.Delay(200).Wait();
        Utility.SendCommand(new RecoverDefaults(Defaults.MicProfiles));
        Task.Delay(200).Wait();
        Utility.SendCommand(new RecoverDefaults(Defaults.Presets));
        Task.Delay(200).Wait();
        Utility.SendCommand(new RecoverDefaults(Defaults.Profiles));
        Task.Delay(200).Wait();

        #endregion

        #region NormalCommands.SetShowTrayIcon

        Utility.SendCommand(new SetShowTrayIcon(false));
        Task.Delay(200).Wait();
        Utility.SendCommand(new SetShowTrayIcon(true));
        Task.Delay(200).Wait();

        #endregion

        #region NormalCommands.SetAutoStartEnabled

        Utility.SendCommand(new SetAutoStartEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(new SetAutoStartEnabled(false));
        Task.Delay(200).Wait();

        #endregion

        #region NormalCommands.SetTextToSpeechEnabled

        Utility.SendCommand(new SetTextToSpeechEnabled(false));
        Task.Delay(200).Wait();

        #endregion
        
        #region NormalCommands.SetAllowNetworkAccess

        Utility.SendCommand(new SetAllowNetworkAccess(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(new SetAllowNetworkAccess(false));
        Task.Delay(200).Wait();

        #endregion
        
        #region NormalCommands.SetLogLevel

        Utility.SendCommand(new SetLogLevel(LogLevelEnum.Debug));
        Task.Delay(200).Wait();
        Utility.SendCommand(new SetLogLevel(LogLevelEnum.Warn));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Profile.Start

        #region DeviceCommands.Profile.Mic

        Utility.SendCommand(serialNumber, new NewMicProfile("Test"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SaveMicProfile());
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SaveMicProfileAs("Test2"));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Profile.Normal

        Utility.SendCommand(serialNumber, new NewProfile("Test"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SaveProfile());
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SaveProfileAs("Test2"));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands

        #region DeviceCommands.ButtonDown

        #region DeviceCommands.ButtonDown.SetActiveEffectPreset

        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset1));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset2));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset3));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset4));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset5));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset6));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetActiveSamplerBank

        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.A));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.B));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.C));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetCoughMuteState

        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.MutedToX));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.MutedToAll));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.Unmuted));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState

        #region DeviceCommands.ButtonDown.SetFaderMuteState.A

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.MutedToX));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.MutedToAll));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.Unmuted));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.B

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.MutedToX));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.MutedToAll));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.Unmuted));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.C

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.MutedToX));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.MutedToAll));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.Unmuted));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.D

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.MutedToX));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.MutedToAll));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.Unmuted));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.ButtonDown.SetFxEnabled

        Utility.SendCommand(serialNumber, new SetFxEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFxEnabled(false));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetHardTuneEnabled

        Utility.SendCommand(serialNumber, new SetHardTuneEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetHardTuneEnabled(false));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetMegaphoneEnabled

        Utility.SendCommand(serialNumber, new SetMegaphoneEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetMegaphoneEnabled(false));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.ButtonDown.SetRobotEnabled

        Utility.SendCommand(serialNumber, new SetRobotEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotEnabled(false));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.CoughButton

        #region DeviceCommands.CoughButton.SetCoughIsHold

        Utility.SendCommand(serialNumber, new SetCoughIsHold(false));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughIsHold(true));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.CoughButton.SetCoughIsHold

        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToLineOut));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToPhones));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToStream));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToVoiceChat));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.All));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Effects

        Utility.SendCommand(serialNumber, new LoadEffectPreset("BadMic"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new RenameActivePreset("BadMic2"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new RenameActivePreset("BadMic"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SaveActivePreset());
        Task.Delay(200).Wait();

        #region DeviceCommands.Effects.Echo

        Utility.SendCommand(serialNumber, new SetEchoAmount(55));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoAmount(-1));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoAmount(101));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoDelayLeft(2500));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoDelayRight(2500));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoFeedback(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoFeedbackLeft(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoFeedbackRight(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoFeedbackXfbLtoR(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoFeedbackXfbRtoL(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoStyle(EchoStyle.ClassicSlap));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEchoTempo(45));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.Gender

        Utility.SendCommand(serialNumber, new SetGenderAmount(12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetGenderStyle(GenderStyle.Narrow));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.HardTune

        Utility.SendCommand(serialNumber, new SetHardTuneAmount(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetHardTuneRate(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetHardTuneSource(HardTuneSource.Game));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetHardTuneStyle(HardTuneStyle.Hard));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetHardTuneWindow(600));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.Megaphone

        Utility.SendCommand(serialNumber, new SetMegaphoneAmount(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetMegaphonePostGain(20));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetMegaphoneStyle(MegaphoneStyle.Megaphone));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.Pitch

        Utility.SendCommand(serialNumber, new SetPitchAmount(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetPitchCharacter(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetPitchStyle(PitchStyle.Narrow));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.Reverb

        Utility.SendCommand(serialNumber, new SetReverbAmount(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbDecay(2000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbDiffuse(50));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbEarlyLevel(0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbHighColour(50));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbHighFactor(25));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbLowColour(50));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbModDepth(25));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbModSpeed(25));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbPreDelay(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbStyle(ReverbStyle.Library));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetReverbTailLevel(0));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Effects.Robot

        Utility.SendCommand(serialNumber, new SetRobotDryMix(0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.Low, 88));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.Medium, 184));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.High, 240));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.Low, 12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.Medium, 12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.High, 12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotPulseWidth(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotThreshold(0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotWaveform(2));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.Low, 12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.Medium, 12));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.High, 12));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.FaderStatus

        Utility.SendCommand(serialNumber, new SetFader(FaderName.A, ChannelName.Headphones));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderMuteFunction(FaderName.A, MuteFunction.ToPhones));
        Task.Delay(200).Wait();

        #region DeviceCommands.FaderStatus.Scribble

        Utility.SendCommand(serialNumber, new SetScribbleIcon(FaderName.A, "level.png"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetScribbleInvert(FaderName.A, true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetScribbleNumber(FaderName.A, "B"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetScribbleText(FaderName.A, "Text"));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Levels

        Utility.SendCommand(serialNumber, new SetBleep(0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetDeeser(100));
        Task.Delay(200).Wait();


        #region DeviceCommands.Submix

        Utility.SendCommand(serialNumber, new SetMonitorMix(OutputDevice.BroadcastMix));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSubMixEnabled(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSubMixLinked(InputDevice.Chat, false));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSubMixOutputMix(OutputDevice.Headphones, SubmixOutput.B));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSubMixVolume(InputDevice.Chat, 10));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Volumes

        Utility.SendCommand(serialNumber, new SetVolume(ChannelName.Music, 10));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Lighting

        #region DeviceCommands.Lighting.Button

        Utility.SendCommand(serialNumber, new SetButtonColours(ButtonLight.Bleep, "#404040", "#ffffff"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetButtonGroupColours(ButtonGroups.EffectSelector, "#404040", "#ffffff"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetButtonOffStyle(ButtonLight.Cough, LightingOffStyle.Dimmed));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetButtonGroupOffStyle(ButtonGroups.EffectSelector, LightingOffStyle.Colour2));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Lighting.Encoder

        Utility.SendCommand(serialNumber, new SetEncoderColour(EncoderEnum.Echo, "#404040", "#ffffff", "#909090"));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Lighting.Fader

        Utility.SendCommand(serialNumber, new SetAllFaderColours("#404040", "#ffffff"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetAllFaderDisplayStyle(FaderDisplayStyle.Gradient));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderColours(FaderName.A, "#101010", "#404040"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetFaderDisplayStyle(FaderName.C, FaderDisplayStyle.TwoColour));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Lighting.Sampler

        Utility.SendCommand(serialNumber, new SetSampleColour(SamplerEnum.SamplerSelectA, "#404040", "#ffffff", "#909090"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSampleOffStyle(SamplerEnum.SamplerSelectA, LightingOffStyle.Dimmed));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Lighting.Simple

        Utility.SendCommand(serialNumber, new SetSimpleColour(SimpleLighting.Global, "#020202"));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.MicStatus

        Utility.SendCommand(serialNumber, new SetMicrophoneGain(MicrophoneType.Dynamic, 40));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetMicrophoneType(MicrophoneType.Dynamic));
        Task.Delay(200).Wait();

        #region DeviceCommands.MicStatus.Compressor

        Utility.SendCommand(serialNumber, new SetCompressorAttack(CompAttackTime.Comp35Ms));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCompressorMakeupGain(24));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCompressorRatio(CompRatio.Ratio2To5));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCompressorReleaseTime(CompReleaseTime.Comp55Ms));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetCompressorThreshold(0));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.MicStatus.Equaliser

        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer125Hz, 250));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer1KHz, 2000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer16KHz, 18000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqGain(SimpleEqualiserEnum.Mid, 9));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqGain(EqualiserEnum.Equalizer16KHz, 9));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer90Hz, 300));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer500Hz, 2000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer8KHz, 18000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqMiniGain(SimpleEqualiserEnum.Mid, 9));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetEqMiniGain(EqualiserMiniEnum.Equalizer8KHz, 9));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.MicStatus.NoiseGate

        Utility.SendCommand(serialNumber, new SetGateActive(true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetGateAttack(GateTiming.Gate110Ms));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetGateAttenuation(100));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetGateRelease(GateTiming.Gate80Ms));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetGateThreshold(0));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Router

        Utility.SendCommand(serialNumber, new SetRouter(InputDevice.Chat, OutputDevice.Headphones, false));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Sampler

        Utility.SendCommand(serialNumber, new SamplerAdd(SamplerBank.A, BankButtonEnum.BottomLeft, "Test.wav"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SamplerAdd(SamplerBank.A, BankButtonEnum.BottomLeft, "Test.wav"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SamplerPlayByIndex(SamplerBank.A, BankButtonEnum.BottomLeft, 0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SamplerRemoveByIndex(SamplerBank.A, BankButtonEnum.BottomLeft, 1));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSamplerFunction(SamplerBank.A, BankButtonEnum.BottomLeft, SamplePlaybackMode.Loop));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSamplerOrder(SamplerBank.A, BankButtonEnum.BottomLeft, SamplePlayOrder.Random));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSampleStartPercent(SamplerBank.A, BankButtonEnum.BottomLeft, 0, 10.0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSampleStopPercent(SamplerBank.A, BankButtonEnum.BottomLeft, 0, 16.0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSamplerPreBufferDuration(5000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetSamplerPreBufferDuration(0));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new ClearSampleProcessError());
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Settings

        Utility.SendCommand(serialNumber, new SetMuteHoldDuration(5000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetMuteHoldDuration(1000));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new SetVcMuteAlsoMuteCm(true));
        Task.Delay(200).Wait();

        #region DeviceCommands.Settings.Display

        Utility.SendCommand(serialNumber, new SetDisplayMode(DisplayComponent.Compressor, DisplayMode.Advanced));
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.ShutdownCommands

        Utility.SendCommand(serialNumber, new SetShutdownCommands(new SetBleep(0)));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new ResetShutdownCommands());
        Task.Delay(200).Wait();

        #endregion

        #endregion

        #region DeviceCommands.Profile.End

        #region DeviceCommands.Profile.Mic

        Utility.SendCommand(serialNumber, new LoadMicProfile("DEFAULT", true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new DeleteMicProfile("Test"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new DeleteMicProfile("Test2"));
        Task.Delay(200).Wait();

        #endregion

        #region DeviceCommands.Profile.Normal

        Utility.SendCommand(serialNumber, new LoadProfile("Main", true));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new DeleteProfile("Test"));
        Task.Delay(200).Wait();
        Utility.SendCommand(serialNumber, new DeleteProfile("Test2"));
        Task.Delay(200).Wait();

        #endregion

        #endregion
    }
}

public class Logger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Console.WriteLine(exception != null ? $"Message: {state} | Exception: {exception}" : $"Message: {state}");
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return false;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }
}