# GoXLR-Utility.NET
A .NET Standard 2.1 Wrapper around the [GoXLR-Utility](https://github.com/GoXLR-on-Linux) V0.9<br/>

# 3rd Party Licenses
[Music Tribe](https://github.com/JulanDeAlb/GoXLR-Utility.NET/blob/develop/LICENSE-3RD-PARTY-MUSIC-TRIBE)<br/>
[GoXLR-Utility](https://github.com/JulanDeAlb/GoXLR-Utility.NET/blob/develop/LICENSE-3RD-PARTY-GOXLR-UTILITY)

# Disclaimer
This project is also not supported by, or affiliated in any way with, TC-Helicon. For the official GoXLR software,
please refer to their website.

# Simple Commands
#### The following Commands can be send via ***SendSimpleCommand(...)***:

Ping,<br/>
OpenUi,<br/>
GetStatus,<br/>
StopDaemon,<br/>
GetHttpState<br/>

**Example: SendSimpleCommand(SimpleCommand.Ping)**

# Commands without SerialNumber
#### The following Commands can be send via ***SendCommand(new ...)***:

OpenPath(PathTypes),<br/>
SetShowTrayIcon(bool),<br/>
SetAutoStartEnabled(bool),<br/>
RecoverDefaults(PathTypes)

# Commands with SerialNumber
#### The following Commands can be send via ***SendCommand(SerialNumber, new ...)***:

**Fader**<br/>
SetFader(FaderName, ChannelName),<br/>
SetFaderMuteFunction(FaderName, MuteFunction)

**Scribble**<br/>
SetScribbleIcon(FaderName, String),<br/>
SetScribbleText(FaderName, String),<br/>
SetScribbleNumber(FaderName, String),<br/>
SetScribbleInvert(FaderName, bool)

**Levels**<br/>
SetDeeser(int),<br/>
SetSwearButtonVolume(int)

**Volumes**<br/>
SetVolume(ChannelName, int)

**Router**<br/>
SetRouter(InputDevice, OutputDevice, bool)

**Cough Button**<br/>
SetCoughMuteFunction(MuteFunction),<br/>
SetCoughIsHold(bool)

**Mic Settings**<br/>
SetMicrophoneType(MicrophoneType),<br/>
SetMicrophoneGain(MicrophoneType, int)

**EQ Settings**<br/>
SetEqMiniGain(MiniEqFrequencies, int),<br/>
SetEqMiniFreq(MiniEqFrequencies, int),<br/>
SetEqGain(EqFrequencies, int),<br/>
SetEqFreq(EqFrequencies, int)

**Gate Settings**<br/>
SetGateThreshold(int),<br/>
SetGateAttenuation(int),<br/>
SetGateAttack(GateTimes),<br/>
SetGateRelease(GateTimes),<br/>
SetGateActive(bool)

**Compressor**<br/>
SetCompressorThreshold(int),<br/>
SetCompressorRatio(CompressorRatio),<br/>
SetCompressorAttack(CompressorAttackTime),<br/>
SetCompressorReleaseTime(CompressorReleaseTime),<br/>
SetCompressorMakeupGain(int)

**Display Mode (Mic)**<br/>
SetElementDisplayMode(DisplayComponent, DisplayMode)

**Colours**<br/>
SetFaderDisplayStyle(FaderName, FaderDisplayStyle),<br/>
SetFaderColours(FaderName, String, String),<br/>
SetAllFaderColours(String, String),<br/>
SetAllFaderDisplayStyle(FaderDisplayStyle),<br/>

SetButtonColours(ButtonLight, String, String),<br/>
SetButtonOffStyle(ButtonLight, LightingOffStyle),<br/>
SetButtonGroupColours(ButtonGroups, String, String),<br/>
SetButtonGroupOffStyle(ButtonGroups, LightingOffStyle),<br/>

SetSimpleColour(SimpleLighting, String),<br/>
SetEncoderColour(EncoderEnum, String, String, String),<br/>
SetSampleColour(SamplerEnum, String, String, String),<br/>
SetSampleOffStyle(SamplerEnum, LightingOffStyle),

**Effects**<br/>
LoadEffectPreset(String),<br/>
RenameActivePreset(String),<br/>
SaveActivePreset(),<br/>

SetReverbStyle(ReverbStyle),<br/>
SetReverbAmount(int),<br/>
SetReverbDecay(int),<br/>
SetReverbEarlyLevel(int),<br/>
SetReverbTailLevel(int),<br/>
SetReverbPreDelay(int),<br/>
SetReverbLowColour(int),<br/>
SetReverbHighColour(int),<br/>
SetReverbHighFactor(int),<br/>
SetReverbDiffuse(int),<br/>
SetReverbModSpeed(int),<br/>
SetReverbModDepth(int),<br/>

SetEchoStyle(EchoStyle),<br/>
SetEchoAmount(int),<br/>
SetEchoFeedback(int),<br/>
SetEchoTempo(int),<br/>
SetEchoDelayLeft(int),<br/>
SetEchoDelayRight(int),<br/>
SetEchoFeedbackLeft(int),<br/>
SetEchoFeedbackRight(int),<br/>
SetEchoFeedbackXFBLtoR(int),<br/>
SetEchoFeedbackXFBRtoL(int),<br/>

SetPitchStyle(PitchStyle),<br/>
SetPitchAmount(int),<br/>
SetPitchCharacter(int),<br/>

SetGenderStyle(GenderStyle),<br/>
SetGenderAmount(int),<br/>

SetMegaphoneStyle(MegaphoneStyle),<br/>
SetMegaphoneAmount(int),<br/>
SetMegaphonePostGain(int),<br/>

SetRobotStyle(RobotStyle),<br/>
SetRobotGain(RobotRange, int),<br/>
SetRobotFreq(RobotRange, int),<br/> (Needs check)
SetRobotWidth(RobotRange, int),<br/>
SetRobotWaveform(int),<br/>
SetRobotPulseWidth(int),<br/>
SetRobotThreshold(int),<br/>
SetRobotDryMix(int),<br/>

SetHardTuneStyle(HardTuneStyle),<br/>
SetHardTuneAmount(int),<br/>
SetHardTuneRate(int),<br/>
SetHardTuneWindow(int),<br/>
SetHardTuneSource(HardTuneSource)

**Profile**<br/>
NewProfile(String),<br/>
LoadProfile(String),<br/>
LoadProfileColours(String),<br/>
SaveProfile(),<br/>
SaveProfileAs(String),<br/>
DeleteProfile(String)

**Mic Profile**<br/>
LoadMicProfile(String),<br/>
SaveMicProfile(),<br/>
SaveMicProfileAs(String),<br/>
DeleteMicProfile(String)

**General Settings**<br/>
SetMuteHoldDuration(int),<br/>
SetVCMuteAlsoMuteCM(bool)<br/>

**These control the current GoXLR 'State'**<br/>
SetActiveEffectPreset(EffectBankPresets),<br/>
SetActiveSamplerBank(SampleBank),<br/>
SetMegaphoneEnabled(bool),<br/>
SetRobotEnabled(bool),<br/>
SetHardTuneEnabled(bool),<br/>
SetFXEnabled(bool),<br/>
SetFaderMuteState(FaderName, MuteState),<br/>
SetCoughMuteState(MuteState)