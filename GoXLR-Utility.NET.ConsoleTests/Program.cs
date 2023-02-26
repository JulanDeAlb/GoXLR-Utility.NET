using GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Commands.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;

namespace GoXLR_Utility.NET.ConsoleTests;

public class Program
{
    private static Utility _utility = new Utility();

    public static void Main(string[] args)
    {
        _utility.Connect();
        Console.ReadKey();
        _utility.SendCommand(_utility.AvailableSerialNumbers[0], new SetButtonGroupColours(ButtonGroupsEnum.SampleBankSelector, "004004", "ffffff"));
        Console.ReadKey();
        AllEvents(_utility.AvailableSerialNumbers[0]);
        Console.WriteLine("Subscribed to Events");
        Console.ReadKey();
    }

    public static void AllEvents(string serialNumber)
    {
        _utility.Status.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Config

        _utility.Status.Config.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Device
        
        _utility.Status.Mixers[serialNumber].PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region ButtonDown

        _utility.Status.Mixers[serialNumber].ButtonDown.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region CoughButton

        _utility.Status.Mixers[serialNumber].CoughButton.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region Effects

        _utility.Status.Mixers[serialNumber].Effects.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        _utility.Status.Mixers[serialNumber].Effects.Current.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.PresetNames.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Effects.Current

        _utility.Status.Mixers[serialNumber].Effects.Current.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        _utility.Status.Mixers[serialNumber].Effects.Current.Echo.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.Current.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.Current.HardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.Current.Megaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.Current.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Mixers[serialNumber].Effects.Current.Robot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        

        #region Effects.Current.Gender

        _utility.Status.Mixers[serialNumber].Effects.Current.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.HardTune

        _utility.Status.Mixers[serialNumber].Effects.Current.HardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Megaphone

        _utility.Status.Mixers[serialNumber].Effects.Current.Megaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Pitch

        _utility.Status.Mixers[serialNumber].Effects.Current.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Reverb

        _utility.Status.Mixers[serialNumber].Effects.Current.Reverb.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Effects.Current.Robot

        _utility.Status.Mixers[serialNumber].Effects.Current.Robot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Effects.PresetNames

        _utility.Status.Mixers[serialNumber].Effects.PresetNames.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus

        _utility.Status.Mixers[serialNumber].FaderStatus.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderA

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderA.Scribble

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderA.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderB

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderB.Scribble

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderB.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderC

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderC.Scribble

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderC.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region FaderStatus.FaderD

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderD.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region FaderStatus.FaderD.Scribble

        _utility.Status.Mixers[serialNumber].FaderStatus.FaderD.Scribble.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion
        
        #region Levels

        _utility.Status.Mixers[serialNumber].Levels.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Levels.Volume

        _utility.Status.Mixers[serialNumber].Levels.Volumes.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting

        _utility.Status.Mixers[serialNumber].Lighting.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button

        _utility.Status.Mixers[serialNumber].Lighting.Button.PropertyChanged+= (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Bleep

        _utility.Status.Mixers[serialNumber].Lighting.Button.Bleep.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Bleep.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.Bleep.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Cough

        _utility.Status.Mixers[serialNumber].Lighting.Button.Cough.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Cough.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.Cough.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectFx

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectFx.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectFx.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectFx.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectHardTune

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectHardTune.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectHardTune.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectHardTune.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectMegaphone

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectMegaphone.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectMegaphone.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectMegaphone.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectRobot

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectRobot.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectRobot.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectRobot.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect1

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect1.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect1.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect1.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect2

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect2.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect2.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect2.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect3

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect3.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect3.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect3.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect4

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect4.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect4.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect4.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect5

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect5.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect5.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect5.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.EffectSelect6

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect6.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.EffectSelect6.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.EffectSelect6.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader1Mute

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderAMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader1Mute.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderAMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader2Mute

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderBMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader2Mute.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderBMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader3Mute

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderCMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader3Mute.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderCMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region Lighting.Button.Fader4Mute

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderDMute.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Button.Fader4Mute.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Button.FaderDMute.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Encoder

        _utility.Status.Mixers[serialNumber].Lighting.Encoder.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Encoder.Echo

        _utility.Status.Mixers[serialNumber].Lighting.Encoder.Echo.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Gender

        _utility.Status.Mixers[serialNumber].Lighting.Encoder.Gender.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Pitch

        _utility.Status.Mixers[serialNumber].Lighting.Encoder.Pitch.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region Lighting.Encoder.Reverb

        _utility.Status.Mixers[serialNumber].Lighting.Encoder.Reverb.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader

        _utility.Status.Mixers[serialNumber].Lighting.Fader.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Fader.A

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.A.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderA.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.B

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.B.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderB.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.C

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.C.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderC.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Fader.D

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderD.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Lighting.Fader.D.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Fader.FaderD.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Sampler

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.A

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.A.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerA.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Sampler.B

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.B.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerB.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Lighting.Sampler.C

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Lighting.Sampler.C.Colour

        _utility.Status.Mixers[serialNumber].Lighting.Sampler.SamplerC.Colour.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Lighting.Simple

        _utility.Status.Mixers[serialNumber].Lighting.Simple.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region MicStatus

        _utility.Status.Mixers[serialNumber].MicStatus.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.Equaliser

        _utility.Status.Mixers[serialNumber].MicStatus.Equaliser.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.Equaliser.Gain

        _utility.Status.Mixers[serialNumber].MicStatus.Equaliser.Gain.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.Equaliser.Frequency

        _utility.Status.Mixers[serialNumber].MicStatus.Equaliser.Frequency.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion
        
        #region MicStatus.EqualiserMini

        _utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region MicStatus.EqualiserMini.GainMini

        _utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.Gain.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.EqualiserMini.FrequencyMini

        _utility.Status.Mixers[serialNumber].MicStatus.EqualiserMini.Frequency.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region MicStatus.MicCompressor

        _utility.Status.Mixers[serialNumber].MicStatus.Compressor.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
        
        #region MicStatus.MicGains

        _utility.Status.Mixers[serialNumber].MicStatus.MicGains.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #region MicStatus.NoiseGate

        _utility.Status.Mixers[serialNumber].MicStatus.NoiseGate.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #region Router

        _utility.Status.Mixers[serialNumber].Router.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}"); 

        #endregion

        #region Sampler

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.BottomLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.BottomRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.TopLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.A.TopRight.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankA.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.B

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.BottomLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.B.BottomRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.B.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.A.TopLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.A.TopLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.B.TopRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.B.TopRight.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankB.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion
        
        #region Sampler.C

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.BottomLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.BottomRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.C.BottomLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.BottomLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.TopLeft

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopLeft.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        
        #region Sampler.C.TopLeft.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopLeft.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #region Sampler.C.TopRight

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopRight.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region Sampler.C.TopRight.Samples

        _utility.Status.Mixers[serialNumber].Sampler.SamplerBanks.SamplerBankC.TopRight.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");

        #endregion

        #endregion

        #endregion

        #endregion

        #region Settings

        _utility.Status.Mixers[serialNumber].Settings.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #region GuiDisplayEvents

        _utility.Status.Mixers[serialNumber].Settings.Display.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion

        #endregion

        #endregion

        #region Files

        _utility.Status.Files.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");
        _utility.Status.Files.Icons.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        _utility.Status.Files.MicProfiles.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        _utility.Status.Files.Presets.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        _utility.Status.Files.Profiles.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        //_utility.Status.Files.Samples.CollectionChanged += (sender, args) => Console.WriteLine($"{sender} | {args.Action} | {args.NewItems} | {args.NewStartingIndex} | {args.OldItems} | {args.OldStartingIndex}");
        
        #endregion

        #region Path

        _utility.Status.Paths.PropertyChanged += (sender, args) => Console.WriteLine($"{sender} | {args.PropertyName}");

        #endregion
    }
}