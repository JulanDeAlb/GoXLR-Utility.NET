# GoXLR-Utility.NET
A .NET Wrapper around the [GoXLR-Utility](https://github.com/GoXLR-on-Linux) V0.11

This project is work in progress.

If you are on a Linux machine and the Connect() does not work, please use: Connect("ws://localhost:14564/api/websocket").

**If you encounter any issues, feel free to report it.**

# Licenses
[GoXLR-Utility.NET](https://github.com/JulanDeAlb/GoXLR-Utility.NET/blob/develop/LICENSE)

### 3rd Party
[Music Tribe](https://github.com/JulanDeAlb/GoXLR-Utility.NET/blob/develop/LICENSE-3RD-PARTY-MUSIC-TRIBE)  
[GoXLR-Utility](https://github.com/JulanDeAlb/GoXLR-Utility.NET/blob/develop/LICENSE-3RD-PARTY-GOXLR-UTILITY)

# Disclaimer
This project is also not supported by, or affiliated in any way with, TC-Helicon. For the official GoXLR software,
please refer to their website.

# Simple Commands
#### The following Commands can be send via ***SendSimpleCommand(...)***:

Ping,  
OpenUi,  
GetStatus,  
StopDaemon,  
GetHttpState

**Example: SendSimpleCommand(SimpleCommand.Ping)**

# Commands without SerialNumber
#### The following Commands can be send via ***SendCommand(new ...)***:

OpenPath(PathTypes),  
SetShowTrayIcon(bool),  
SetAutoStartEnabled(bool),  
RecoverDefaults(PathTypes),  
SetTextToSpeechEnabled(bool)

# Commands with SerialNumber
#### The following Commands can be send via ***SendCommand(SerialNumber, new ...)***:

**Colours**  
SetFaderDisplayStyle(FaderName, FaderDisplayStyle),  
SetFaderColours(FaderName, String, String),  
SetAllFaderColours(String, String),  
SetAllFaderDisplayStyle(FaderDisplayStyle),

SetButtonColours(ButtonLight, String, String),  
SetButtonOffStyle(ButtonLight, LightingOffStyle),  
SetButtonGroupColours(ButtonGroups, String, String),  
SetButtonGroupOffStyle(ButtonGroups, LightingOffStyle),

SetSimpleColour(SimpleLighting, String),  
SetEncoderColour(EncoderEnum, String, String, String),  
SetSampleColour(SamplerEnum, String, String, String),  
SetSampleOffStyle(SamplerEnum, LightingOffStyle)

**Compressor**  
SetCompressorThreshold(int),  
SetCompressorRatio(CompressorRatio),  
SetCompressorAttack(CompressorAttackTime),  
SetCompressorReleaseTime(CompressorReleaseTime),  
SetCompressorMakeupGain(int)

**Cough Button**  
SetCoughMuteFunction(MuteFunction),  
SetCoughIsHold(bool)

**Display Mode (Mic)**  
SetElementDisplayMode(DisplayComponent, DisplayMode)

**Effects**  
LoadEffectPreset(String),  
RenameActivePreset(String),  
SaveActivePreset(),

SetReverbStyle(ReverbStyle),  
SetReverbAmount(int),  
SetReverbDecay(int),  
SetReverbEarlyLevel(int),  
SetReverbTailLevel(int),  
SetReverbPreDelay(int),  
SetReverbLowColour(int),  
SetReverbHighColour(int),  
SetReverbHighFactor(int),  
SetReverbDiffuse(int),  
SetReverbModSpeed(int),  
SetReverbModDepth(int),

SetEchoStyle(EchoStyle),  
SetEchoAmount(int),  
SetEchoFeedback(int),  
SetEchoTempo(int),  
SetEchoDelayLeft(int),  
SetEchoDelayRight(int),  
SetEchoFeedbackLeft(int),  
SetEchoFeedbackRight(int),  
SetEchoFeedbackXFBLtoR(int),  
SetEchoFeedbackXFBRtoL(int),

SetPitchStyle(PitchStyle),  
SetPitchAmount(int),  
SetPitchCharacter(int),

SetGenderStyle(GenderStyle),  
SetGenderAmount(int),

SetMegaphoneStyle(MegaphoneStyle),  
SetMegaphoneAmount(int),  
SetMegaphonePostGain(int),

SetRobotStyle(RobotStyle),  
SetRobotGain(RobotRange, int),  
SetRobotFreq(RobotRange, int),   (Needs check)  
SetRobotWidth(RobotRange, int),  
SetRobotWaveform(int),  
SetRobotPulseWidth(int),  
SetRobotThreshold(int),  
SetRobotDryMix(int),

SetHardTuneStyle(HardTuneStyle),  
SetHardTuneAmount(int),  
SetHardTuneRate(int),  
SetHardTuneWindow(int),  
SetHardTuneSource(HardTuneSource)

**EQ Settings**  
SetEqMiniGain(MiniEqFrequencies, int),  
SetEqMiniFreq(MiniEqFrequencies, int),  
SetEqGain(EqFrequencies, int),  
SetEqFreq(EqFrequencies, int)

**Fader**  
SetFader(FaderName, ChannelName),  
SetFaderMuteFunction(FaderName, MuteFunction)

**Gate Settings**  
SetGateThreshold(int),  
SetGateAttenuation(int),  
SetGateAttack(GateTimes),  
SetGateRelease(GateTimes),  
SetGateActive(bool)

**General Settings**  
SetMuteHoldDuration(int),  
SetVCMuteAlsoMuteCM(bool)

**Levels**  
SetDeeser(int),  
SetSwearButtonVolume(int)

**Mic Profile**  
LoadMicProfile(String),  
SaveMicProfile(),  
SaveMicProfileAs(String),  
DeleteMicProfile(String)

**Mic Settings**  
SetMicrophoneType(MicrophoneType),  
SetMicrophoneGain(MicrophoneType, int)

**Profile**  
NewProfile(String),  
LoadProfile(String),  
LoadProfileColours(String),  
SaveProfile(),  
SaveProfileAs(String),  
DeleteProfile(String)

**Router**  
SetRouter(InputDevice, OutputDevice, bool)

**Sampler**
SamplerAdd(Bank, Button, string),  
SamplerPlayByIndex(Bank, Button, int),  
SamplerRemoveByIndex(Bank, Button, int),  
SetSamplerFunction(Bank, Button, PlaybackMode),  
SetSamplerOrder(Bank, Button, Order),  
SetSampleStartPercent(Bank, Button, int, double),  
SetSampleStopPercent(Bank, Button, int, double)

**Scribble**  
SetScribbleIcon(FaderName, String),  
SetScribbleText(FaderName, String),  
SetScribbleNumber(FaderName, String),  
SetScribbleInvert(FaderName, bool)

**Shutdown Commands**  
ResetShutdownCommands(),  
SetShutdownCommands(DeviceCommand),  
SetShutdownCommands(IEnumberable<DeviceCommand>)

**Submix**  
SetSubMixEnabled(bool)
SetSubMixLinked(ChannelName, bool)
SetSubMixOutputMix(ChannelName, SubmixOutput)
SetSubMixVolume(ChannelName, int)

**These control the current GoXLR 'State'**  
SetActiveEffectPreset(EffectBankPresets),  
SetActiveSamplerBank(SampleBank),  
SetMegaphoneEnabled(bool),  
SetRobotEnabled(bool),  
SetHardTuneEnabled(bool),  
SetFXEnabled(bool),  
SetFaderMuteState(FaderName, MuteState),  
SetCoughMuteState(MuteState)

**Volumes**  
SetVolume(ChannelName, int)