using GoXLR_Utility.NET.Commands;
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
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.ConsoleTests;

public static class Program
{
    private static Logger _log = new Logger();
    private static readonly Utility Utility = new(_log);

    public static void Main(string[] args)
    {
        Utility.Connect();
        Console.ReadKey();
        AllEvents(Utility.AvailableSerialNumbers[0]);
        AllCommands(Utility.AvailableSerialNumbers[0]);
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

    private static void AllCommands(string serialNumber)
    {
        #region NormalCommands

        #region NormalCommands.RecoverDefaults

        Utility.SendCommand(new RecoverDefaults(PathEnum.Icons));
        Utility.SendCommand(new RecoverDefaults(PathEnum.MicProfiles));
        Utility.SendCommand(new RecoverDefaults(PathEnum.Presets));
        Utility.SendCommand(new RecoverDefaults(PathEnum.Profiles));
        Utility.SendCommand(new RecoverDefaults(PathEnum.Samples));

        #endregion

        #region NormalCommands.SetShowTrayIcon

        Utility.SendCommand(new SetShowTrayIcon(false));
        Utility.SendCommand(new SetShowTrayIcon(true));

        #endregion

        #region NormalCommands.SetAutoStartEnabled

        Utility.SendCommand(new SetAutoStartEnabled(true));
        Utility.SendCommand(new SetAutoStartEnabled(false));

        #endregion

        #region NormalCommands.SetTextToSpeechEnabled

        Utility.SendCommand(new SetTextToSpeechEnabled(true));
        Utility.SendCommand(new SetAutoStartEnabled(false));

        #endregion

        #endregion

        #region DeviceCommands.Profile.Start

        #region DeviceCommands.Profile.Mic

        Utility.SendCommand(serialNumber, new NewMicProfile("Test"));
        Utility.SendCommand(serialNumber, new SaveMicProfile());
        Utility.SendCommand(serialNumber, new SaveMicProfileAs("Test2"));

        #endregion

        #region DeviceCommands.Profile.Normal

        Utility.SendCommand(serialNumber, new NewProfile("Test"));
        Utility.SendCommand(serialNumber, new SaveProfile());
        Utility.SendCommand(serialNumber, new SaveProfileAs("Test2"));

        #endregion

        #endregion

        #region DeviceCommands

        #region DeviceCommands.ButtonDown

        #region DeviceCommands.ButtonDown.SetActiveEffectPreset

        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset1));
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset2));
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset3));
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset4));
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset5));
        Utility.SendCommand(serialNumber, new SetActiveEffectPreset(EffectBankPresets.Preset6));

        #endregion

        #region DeviceCommands.ButtonDown.SetActiveSamplerBank

        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.A));
        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.B));
        Utility.SendCommand(serialNumber, new SetActiveSamplerBank(SamplerBank.C));

        #endregion

        #region DeviceCommands.ButtonDown.SetCoughMuteState

        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.MutedToX));
        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.MutedToAll));
        Utility.SendCommand(serialNumber, new SetCoughMuteState(MuteState.Unmuted));

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState

        #region DeviceCommands.ButtonDown.SetFaderMuteState.A

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.MutedToX));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.MutedToAll));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.A, MuteState.Unmuted));

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.B

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.MutedToX));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.MutedToAll));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.B, MuteState.Unmuted));

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.C

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.MutedToX));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.MutedToAll));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.C, MuteState.Unmuted));

        #endregion

        #region DeviceCommands.ButtonDown.SetFaderMuteState.D

        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.MutedToX));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.MutedToAll));
        Utility.SendCommand(serialNumber, new SetFaderMuteState(FaderName.D, MuteState.Unmuted));

        #endregion

        #endregion

        #region DeviceCommands.ButtonDown.SetFxEnabled

        Utility.SendCommand(serialNumber, new SetFxEnabled(true));
        Utility.SendCommand(serialNumber, new SetFxEnabled(false));

        #endregion

        #region DeviceCommands.ButtonDown.SetHardTuneEnabled

        Utility.SendCommand(serialNumber, new SetHardTuneEnabled(true));
        Utility.SendCommand(serialNumber, new SetHardTuneEnabled(false));

        #endregion

        #region DeviceCommands.ButtonDown.SetMegaphoneEnabled

        Utility.SendCommand(serialNumber, new SetMegaphoneEnabled(true));
        Utility.SendCommand(serialNumber, new SetMegaphoneEnabled(false));

        #endregion

        #region DeviceCommands.ButtonDown.SetRobotEnabled

        Utility.SendCommand(serialNumber, new SetRobotEnabled(true));
        Utility.SendCommand(serialNumber, new SetRobotEnabled(false));

        #endregion

        #endregion

        #region DeviceCommands.CoughButton

        #region DeviceCommands.CoughButton.SetCoughIsHold

        Utility.SendCommand(serialNumber, new SetCoughIsHold(false));
        Utility.SendCommand(serialNumber, new SetCoughIsHold(true));

        #endregion

        #region DeviceCommands.CoughButton.SetCoughIsHold

        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToLineOut));
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToPhones));
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToStream));
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.ToVoiceChat));
        Utility.SendCommand(serialNumber, new SetCoughMuteFunction(MuteFunction.All));

        #endregion

        #endregion

        #region DeviceCommands.Effects

        Utility.SendCommand(serialNumber, new LoadEffectPreset("BadMic"));
        Utility.SendCommand(serialNumber, new RenameActivePreset("BadMic2"));
        Utility.SendCommand(serialNumber, new RenameActivePreset("BadMic"));
        Utility.SendCommand(serialNumber, new SaveActivePreset());

        #region DeviceCommands.Effects.Echo

        Utility.SendCommand(serialNumber, new SetEchoAmount(55));
        Utility.SendCommand(serialNumber, new SetEchoAmount(-1));
        Utility.SendCommand(serialNumber, new SetEchoAmount(101));
        Utility.SendCommand(serialNumber, new SetEchoDelayLeft(2500));
        Utility.SendCommand(serialNumber, new SetEchoDelayRight(2500));
        Utility.SendCommand(serialNumber, new SetEchoFeedback(100));
        Utility.SendCommand(serialNumber, new SetEchoFeedbackLeft(100));
        Utility.SendCommand(serialNumber, new SetEchoFeedbackRight(100));
        Utility.SendCommand(serialNumber, new SetEchoFeedbackXfbLtoR(100));
        Utility.SendCommand(serialNumber, new SetEchoFeedbackXfbRtoL(100));
        Utility.SendCommand(serialNumber, new SetEchoStyle(EchoStyle.ClassicSlap));
        Utility.SendCommand(serialNumber, new SetEchoTempo(45));

        #endregion

        #region DeviceCommands.Effects.Gender

        Utility.SendCommand(serialNumber, new SetGenderAmount(12));
        Utility.SendCommand(serialNumber, new SetGenderStyle(GenderStyle.Narrow));

        #endregion

        #region DeviceCommands.Effects.HardTune

        Utility.SendCommand(serialNumber, new SetHardTuneAmount(100));
        Utility.SendCommand(serialNumber, new SetHardTuneRate(100));
        Utility.SendCommand(serialNumber, new SetHardTuneSource(HardTuneSource.Game));
        Utility.SendCommand(serialNumber, new SetHardTuneStyle(HardTuneStyle.Hard));
        Utility.SendCommand(serialNumber, new SetHardTuneWindow(600));

        #endregion

        #region DeviceCommands.Effects.Megaphone

        Utility.SendCommand(serialNumber, new SetMegaphoneAmount(100));
        Utility.SendCommand(serialNumber, new SetMegaphonePostGain(20));
        Utility.SendCommand(serialNumber, new SetMegaphoneStyle(MegaphoneStyle.Megaphone));

        #endregion

        #region DeviceCommands.Effects.Pitch

        Utility.SendCommand(serialNumber, new SetPitchAmount(100));
        Utility.SendCommand(serialNumber, new SetPitchCharacter(100));
        Utility.SendCommand(serialNumber, new SetPitchStyle(PitchStyle.Narrow));

        #endregion

        #region DeviceCommands.Effects.Reverb

        Utility.SendCommand(serialNumber, new SetReverbAmount(100));
        Utility.SendCommand(serialNumber, new SetReverbDecay(2000));
        Utility.SendCommand(serialNumber, new SetReverbDiffuse(50));
        Utility.SendCommand(serialNumber, new SetReverbEarlyLevel(0));
        Utility.SendCommand(serialNumber, new SetReverbHighColour(50));
        Utility.SendCommand(serialNumber, new SetReverbHighFactor(25));
        Utility.SendCommand(serialNumber, new SetReverbLowColour(50));
        Utility.SendCommand(serialNumber, new SetReverbModDepth(25));
        Utility.SendCommand(serialNumber, new SetReverbModSpeed(25));
        Utility.SendCommand(serialNumber, new SetReverbPreDelay(100));
        Utility.SendCommand(serialNumber, new SetReverbStyle(ReverbStyle.Library));
        Utility.SendCommand(serialNumber, new SetReverbTailLevel(0));

        #endregion

        #region DeviceCommands.Effects.Robot

        Utility.SendCommand(serialNumber, new SetRobotDryMix(0));
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.Low, 88));
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.Medium, 184));
        Utility.SendCommand(serialNumber, new SetRobotFreq(RobotRange.High, 240));
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.Low, 12));
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.Medium, 12));
        Utility.SendCommand(serialNumber, new SetRobotGain(RobotRange.High, 12));
        Utility.SendCommand(serialNumber, new SetRobotPulseWidth(100));
        Utility.SendCommand(serialNumber, new SetRobotThreshold(0));
        Utility.SendCommand(serialNumber, new SetRobotWaveform(2));
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.Low, 12));
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.Medium, 12));
        Utility.SendCommand(serialNumber, new SetRobotWidth(RobotRange.High, 12));

        #endregion

        #endregion

        #region DeviceCommands.FaderStatus

        Utility.SendCommand(serialNumber, new SetFader(FaderName.A, ChannelName.Headphones));
        Utility.SendCommand(serialNumber, new SetFaderMuteFunction(FaderName.A, MuteFunction.ToPhones));

        #region DeviceCommands.FaderStatus.Scribble

        Utility.SendCommand(serialNumber, new SetScribbleIcon(FaderName.A, "level.png"));
        Utility.SendCommand(serialNumber, new SetScribbleInvert(FaderName.A, true));
        Utility.SendCommand(serialNumber, new SetScribbleNumber(FaderName.A, "B"));
        Utility.SendCommand(serialNumber, new SetScribbleText(FaderName.A, "Text"));

        #endregion

        #endregion

        #region DeviceCommands.Levels

        Utility.SendCommand(serialNumber, new SetBleep(0));
        Utility.SendCommand(serialNumber, new SetDeeser(100));


        #region DeviceCommands.Submix

        Utility.SendCommand(serialNumber, new SetSubMixEnabled(true));
        Utility.SendCommand(serialNumber, new SetSubMixLinked(InputDevice.Chat, false));
        Utility.SendCommand(serialNumber, new SetSubMixOutputMix(OutputDevice.Headphones, SubmixOutput.B));
        Utility.SendCommand(serialNumber, new SetSubMixVolume(InputDevice.Chat, 10));

        #endregion

        #region DeviceCommands.Volumes

        Utility.SendCommand(serialNumber, new SetVolume(ChannelName.Music, 10));

        #endregion

        #endregion

        #region DeviceCommands.Lighting

        #region DeviceCommands.Lighting.Button

        Utility.SendCommand(serialNumber, new SetButtonColours(ButtonLight.Bleep, "#404040", "#ffffff"));
        Utility.SendCommand(serialNumber, new SetButtonGroupColours(ButtonGroups.EffectSelector, "#404040", "#ffffff"));
        Utility.SendCommand(serialNumber, new SetButtonOffStyle(ButtonLight.Cough, LightingOffStyle.Dimmed));
        Utility.SendCommand(serialNumber, new SetButtonGroupOffStyle(ButtonGroups.SamplerButtons, LightingOffStyle.Colour2));

        #endregion

        #region DeviceCommands.Lighting.Encoder

        Utility.SendCommand(serialNumber, new SetEncoderColour(EncoderEnum.Echo, "#404040", "#ffffff", "#909090"));

        #endregion

        #region DeviceCommands.Lighting.Fader

        Utility.SendCommand(serialNumber, new SetAllFaderColours("#404040", "#ffffff"));
        Utility.SendCommand(serialNumber, new SetAllFaderDisplayStyle(FaderDisplayStyle.Gradient));
        Utility.SendCommand(serialNumber, new SetFaderColours(FaderName.A, "#101010", "#404040"));
        Utility.SendCommand(serialNumber, new SetFaderDisplayStyle(FaderName.C, FaderDisplayStyle.TwoColour));

        #endregion

        #region DeviceCommands.Lighting.Sampler

        Utility.SendCommand(serialNumber, new SetSampleColour(SamplerEnum.SamplerSelectA, "#404040", "#ffffff", "#909090"));
        Utility.SendCommand(serialNumber, new SetSampleOffStyle(SamplerEnum.SamplerSelectA, LightingOffStyle.Dimmed));

        #endregion

        #region DeviceCommands.Lighting.Simple

        Utility.SendCommand(serialNumber, new SetSimpleColour(SimpleLighting.Global, "#020202", "#909090"));

        #endregion

        #endregion

        #region DeviceCommands.MicStatus

        Utility.SendCommand(serialNumber, new SetMicrophoneGain(MicrophoneType.Dynamic, 40));
        Utility.SendCommand(serialNumber, new SetMicrophoneType(MicrophoneType.Dynamic));

        #region DeviceCommands.MicStatus.Compressor

        Utility.SendCommand(serialNumber, new SetCompressorAttack(CompAttackTime.Comp35Ms));
        Utility.SendCommand(serialNumber, new SetCompressorMakeupGain(24));
        Utility.SendCommand(serialNumber, new SetCompressorRatio(CompRatio.Ratio2To5));
        Utility.SendCommand(serialNumber, new SetCompressorReleaseTime(CompReleaseTime.Comp55Ms));
        Utility.SendCommand(serialNumber, new SetCompressorThreshold(0));

        #endregion

        #region DeviceCommands.MicStatus.Equaliser

        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer125Hz, 300));
        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer1KHz, 2000));
        Utility.SendCommand(serialNumber, new SetEqFrequency(EqualiserEnum.Equalizer16KHz, 18000));
        Utility.SendCommand(serialNumber, new SetEqGain(SimpleEqualiserEnum.Mid, 9));
        Utility.SendCommand(serialNumber, new SetEqGain(EqualiserEnum.Equalizer16KHz, 9));
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer90Hz, 300));
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer500Hz, 2000));
        Utility.SendCommand(serialNumber, new SetEqMiniFrequency(EqualiserMiniEnum.Equalizer8KHz, 18000));
        Utility.SendCommand(serialNumber, new SetEqMiniGain(SimpleEqualiserEnum.Mid, 9));
        Utility.SendCommand(serialNumber, new SetEqMiniGain(EqualiserMiniEnum.Equalizer8KHz, 9));

        #endregion

        #region DeviceCommands.MicStatus.NoiseGate

        Utility.SendCommand(serialNumber, new SetGateActive(true));
        Utility.SendCommand(serialNumber, new SetGateAttack(GateTiming.Gate110Ms));
        Utility.SendCommand(serialNumber, new SetGateAttenuation(100));
        Utility.SendCommand(serialNumber, new SetGateRelease(GateTiming.Gate80Ms));
        Utility.SendCommand(serialNumber, new SetGateThreshold(0));

        #endregion

        #endregion

        #region DeviceCommands.Router

        Utility.SendCommand(serialNumber, new SetRouter(InputDevice.Chat, OutputDevice.Headphones, false));

        #endregion

        #region DeviceCommands.Sampler

        Utility.SendCommand(serialNumber, new SamplerAdd(SamplerBank.A, BankButtonEnum.BottomLeft, "Recording_2022-11-12T081058.wav"));
        Utility.SendCommand(serialNumber, new SamplerPlayByIndex(SamplerBank.A, BankButtonEnum.BottomLeft, 0));
        Utility.SendCommand(serialNumber, new SamplerRemoveByIndex(SamplerBank.A, BankButtonEnum.BottomLeft, 1));
        Utility.SendCommand(serialNumber, new SetSamplerFunction(SamplerBank.A, BankButtonEnum.BottomLeft, SamplePlaybackMode.Loop));
        Utility.SendCommand(serialNumber, new SetSamplerOrder(SamplerBank.A, BankButtonEnum.BottomLeft, SamplePlayOrder.Random));
        Utility.SendCommand(serialNumber, new SetSampleStartPercent(SamplerBank.A, BankButtonEnum.BottomLeft, 0, 10.0));
        Utility.SendCommand(serialNumber, new SetSampleStopPercent(SamplerBank.A, BankButtonEnum.BottomLeft, 0, 16.0));

        #endregion

        #region DeviceCommands.Sampler

        Utility.SendCommand(serialNumber, new SetMuteHoldDuration(5000));
        Utility.SendCommand(serialNumber, new SetVcMuteAlsoMuteCm(true));

        #region DeviceCommands.Sampler.Display

        Utility.SendCommand(serialNumber, new SetDisplayMode(DisplayComponent.Compressor, DisplayMode.Advanced));

        #endregion

        #endregion

        #region DeviceCommands.ShutdownCommands

        Utility.SendCommand(serialNumber, new SetShutdownCommands(new SetBleep(0)));
        Utility.SendCommand(serialNumber, new ResetShutdownCommands());

        #endregion

        #endregion

        #region DeviceCommands.Profile.End

        #region DeviceCommands.Profile.Mic

        Utility.SendCommand(serialNumber, new LoadMicProfile("DEFAULT"));
        Utility.SendCommand(serialNumber, new DeleteMicProfile("Test"));
        Utility.SendCommand(serialNumber, new DeleteMicProfile("Test2"));

        #endregion

        #region DeviceCommands.Profile.Normal

        Utility.SendCommand(serialNumber, new LoadProfile("Main"));
        Utility.SendCommand(serialNumber, new DeleteProfile("Test"));
        Utility.SendCommand(serialNumber, new DeleteProfile("Test2"));

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