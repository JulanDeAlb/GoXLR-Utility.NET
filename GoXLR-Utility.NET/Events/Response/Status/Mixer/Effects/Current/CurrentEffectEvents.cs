using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Robot;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current
{
    public class CurrentEffectEvents
    {
        public EchoEffectEvents Echo = new EchoEffectEvents();
        public GenderEffectEvents Gender = new GenderEffectEvents();
        public HardTuneEffectEvents HardTune = new HardTuneEffectEvents();
        public MegaphoneEffectEvents Megaphone = new MegaphoneEffectEvents();
        public PitchEffectEvents Pitch = new PitchEffectEvents();
        public ReverbEffectEvents Reverb = new ReverbEffectEvents();
        public RobotEffectEvents Robot = new RobotEffectEvents();
        
        public event EventHandler<EchoEffectEventArgs> OnEchoChanged;
        public event EventHandler<GenderEffectEventArgs> OnGenderChanged;
        public event EventHandler<HardTuneEffectEventArgs> OnHardTuneChanged;
        public event EventHandler<MegaphoneEffectEventArgs> OnMegaphoneChanged;
        public event EventHandler<PitchEffectEventArgs> OnPitchChanged;
        public event EventHandler<ReverbEffectEventArgs> OnReverbChanged;
        public event EventHandler<RobotEffectEventArgs> OnRobotChanged;

        protected internal void HandleEvents(string serialNumber, object myClass, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged, EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current = new CurrentEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (myClass)
            {
                case EchoEffect echoEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Echo;
                    Echo.HandleEvents(serialNumber, echoEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnEchoChanged, effectEventArgs);
                    break;
                
                case GenderEffect genderEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Gender;
                    Gender.HandleEvents(serialNumber, genderEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnGenderChanged, effectEventArgs);
                    break;
                
                case HardTuneEffect hardTuneEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.HardTune;
                    HardTune.HandleEvents(serialNumber, hardTuneEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnHardTuneChanged, effectEventArgs);
                    break;
                
                case MegaphoneEffect megaphoneEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Megaphone;
                    Megaphone.HandleEvents(serialNumber, megaphoneEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnMegaphoneChanged, effectEventArgs);
                    break;
                
                case PitchEffect pitchEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Pitch;
                    Pitch.HandleEvents(serialNumber, pitchEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnPitchChanged, effectEventArgs);
                    break;
                
                case ReverbEffect reverbEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Reverb;
                    Reverb.HandleEvents(serialNumber, reverbEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnReverbChanged, effectEventArgs);
                    break;
                
                case RobotEffect robotEffect:
                    effectEventArgs.Current.TypeChanged = CurrentEffectEnum.Robot;
                    Robot.HandleEvents(serialNumber, robotEffect, memInfo, effectsChanged,
                        currentEffectChanged, OnRobotChanged, effectEventArgs);
                    break;
                
                default: 
                    var type = myClass.GetType();
                    throw new ArgumentOutOfRangeException(
                        $"Type out of Range in EffectEvents (Effect): {type.Name} | Path: {type.FullName}");
            }            
        }
    }
}