using GoXLR_Utility.NET.Commands.Mixer.Profile.Normal;
using GoXLR_Utility.NET.Commands.Mixer.ShutdownCommands;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.ConsoleTests;

public static class Program
{
    private static Logger _log = new Logger();
    private static readonly Utility Utility = new(_log);

    public static void Main(string[] args)
    {
        var normal = new SetShutdownCommands(new DeleteProfile(""));
        var list = new SetShutdownCommands(new DeleteProfile(""));
        //Utility.Connect();
        Console.ReadKey();
        AllEvents(Utility.AvailableSerialNumbers[0]);
        Console.WriteLine("Subscribed to Events");
        Console.ReadKey();
    }

    private static void AllEvents(string serialNumber)
    {
        Utility.Status.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Events

        #region Config

        Utility.Status.Config.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Device
        
        Utility.Status.Mixers[serialNumber].PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region ButtonDown

        Utility.Status.Mixers[serialNumber].ButtonDown.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region CoughButton

        Utility.Status.Mixers[serialNumber].CoughButton.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Effects

        Utility.Status.Mixers[serialNumber].Effects.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        Utility.Status.Mixers[serialNumber].Effects.Current.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.PresetNames.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Effects.Current

        Utility.Status.Mixers[serialNumber].Effects.Current.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        Utility.Status.Mixers[serialNumber].Effects.Current.Echo.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.Current.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.Current.HardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.Current.Megaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.Current.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Mixers[serialNumber].Effects.Current.Robot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Effects.Current.Echo

        Utility.Status.Mixers[serialNumber].Effects.Current.Echo.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Gender

        Utility.Status.Mixers[serialNumber].Effects.Current.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.HardTune

        Utility.Status.Mixers[serialNumber].Effects.Current.HardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Megaphone

        Utility.Status.Mixers[serialNumber].Effects.Current.Megaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Pitch

        Utility.Status.Mixers[serialNumber].Effects.Current.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Reverb

        Utility.Status.Mixers[serialNumber].Effects.Current.Reverb.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Robot

        Utility.Status.Mixers[serialNumber].Effects.Current.Robot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Effects.PresetNames

        Utility.Status.Mixers[serialNumber].Effects.PresetNames.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus

        Utility.Status.Mixers[serialNumber].FaderStatus.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderA

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderA.Scribble

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderA.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderB

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderB.Scribble

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderB.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderC

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderC.Scribble

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderC.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderD

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderD.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderD.Scribble

        Utility.Status.Mixers[serialNumber].FaderStatus.FaderD.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion
        
        #region Levels

        Utility.Status.Mixers[serialNumber].Levels.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Levels.Submix

        Utility.Status.Mixers[serialNumber].Levels.Submix.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Levels.Submix.Inputs

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Levels.Submix.Inputs.Chat

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Chat.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.Console

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Console.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.Game

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Game.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.LineIn

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.LineIn.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.Mic

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Mic.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.Music

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Music.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.Sample

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.Sample.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Levels.Submix.Inputs.System

        Utility.Status.Mixers[serialNumber].Levels.Submix.Inputs.System.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Levels.Submix.Outputs

        Utility.Status.Mixers[serialNumber].Levels.Submix.Outputs.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Levels.Volume

        Utility.Status.Mixers[serialNumber].Levels.Volumes.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting

        Utility.Status.Mixers[serialNumber].Lighting.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button

        Utility.Status.Mixers[serialNumber].Lighting.Button.PropertyChanged+= (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Bleep

        Utility.Status.Mixers[serialNumber].Lighting.Button.Bleep.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Bleep.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.Bleep.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Cough

        Utility.Status.Mixers[serialNumber].Lighting.Button.Cough.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Cough.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.Cough.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectFx

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectFx.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectFx.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectFx.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectHardTune

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectHardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectHardTune.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectHardTune.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectMegaphone

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectMegaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectMegaphone.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectMegaphone.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectRobot

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectRobot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectRobot.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectRobot.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect1

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect1.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect1.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect1.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect2

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect2.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect2.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect2.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect3

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect3.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect3.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect3.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect4

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect4.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect4.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect4.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect5

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect5.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect5.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect5.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect6

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect6.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect6.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect6.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader1Mute

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderAMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader1Mute.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderAMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader2Mute

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderBMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader2Mute.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderBMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader3Mute

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderCMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader3Mute.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderCMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader4Mute

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderDMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader4Mute.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Button.FaderDMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Encoder

        Utility.Status.Mixers[serialNumber].Lighting.Encoder.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Encoder.Echo

        Utility.Status.Mixers[serialNumber].Lighting.Encoder.Echo.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Gender

        Utility.Status.Mixers[serialNumber].Lighting.Encoder.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Pitch

        Utility.Status.Mixers[serialNumber].Lighting.Encoder.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Reverb

        Utility.Status.Mixers[serialNumber].Lighting.Encoder.Reverb.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader

        Utility.Status.Mixers[serialNumber].Lighting.Fader.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Fader.A

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.A.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderA.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.B

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.B.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderB.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.C

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.C.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderC.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.D

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderD.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.D.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Fader.FaderD.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Sampler

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.A

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.A.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerA.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Sampler.B

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.B.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerB.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Sampler.C

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.C.Colour

        Utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerC.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Simple

        Utility.Status.Mixers[serialNumber].Lighting.Simple.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region MicStatus

        Utility.Status.Mixers[serialNumber].MicStatus.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.Equaliser

        Utility.Status.Mixers[serialNumber].MicStatus.Equaliser.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.Equaliser.Gain

        Utility.Status.Mixers[serialNumber].MicStatus.Equaliser.Gain.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.Equaliser.Frequency

        Utility.Status.Mixers[serialNumber].MicStatus.Equaliser.Frequency.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region MicStatus.EqualiserMini

        Utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.EqualiserMini.GainMini

        Utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.Gain.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.EqualiserMini.FrequencyMini

        Utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.Frequency.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region MicStatus.MicCompressor

        Utility.Status.Mixers[serialNumber].MicStatus.Compressor.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region MicStatus.MicGains

        Utility.Status.Mixers[serialNumber].MicStatus.MicGains.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.NoiseGate

        Utility.Status.Mixers[serialNumber].MicStatus.NoiseGate.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Router

        Utility.Status.Mixers[serialNumber].Router.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Sampler

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.BottomLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.BottomRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.TopLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.TopRight.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.B

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.BottomLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.B.BottomRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.B.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.TopLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.B.TopRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.TopRight.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.C

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.BottomLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.BottomRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.C.BottomLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.TopLeft

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.C.TopLeft.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.TopRight

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.TopRight.Samples

        Utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion

        #region Shutdown

        Utility.Status.Mixers[serialNumber].ShutdownCommands.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Settings

        Utility.Status.Mixers[serialNumber].Settings.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region GuiDisplayEvents

        Utility.Status.Mixers[serialNumber].Settings.Display.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Files

        Utility.Status.Files.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        Utility.Status.Files.Icons.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        Utility.Status.Files.MicProfiles.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        Utility.Status.Files.Presets.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        Utility.Status.Files.Profiles.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        //_utility.Status.Files.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        
        #endregion

        #region Path

        Utility.Status.Paths.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

#endregion

        #endregion
    }
}

public class Logger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Console.WriteLine($"Message: {state} | Exception: {exception}");
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