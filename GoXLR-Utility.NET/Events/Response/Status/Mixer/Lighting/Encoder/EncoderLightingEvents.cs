using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Encoder
{
    public class EncoderLightingEvents
    {
        public ThreeColourEvents Echo = new ThreeColourEvents();
        public ThreeColourEvents Gender = new ThreeColourEvents();
        public ThreeColourEvents Pitch = new ThreeColourEvents();
        public ThreeColourEvents Reverb = new ThreeColourEvents();

        public event EventHandler<ThreeColourEventArgs> OnEchoChanged;
        public event EventHandler<ThreeColourEventArgs> OnGenderChanged;
        public event EventHandler<ThreeColourEventArgs> OnPitchChanged;
        public event EventHandler<ThreeColourEventArgs> OnReverbChanged;

        protected internal void HandleEvents(string serialNumber, ThreeColour encoderLight, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<EncoderLightingEventArgs> encoderChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Encoder = new EncoderLightingEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (encoderLight)
            {
                case EchoColour echoColour:
                    lightingEventArgs.Encoder.TypeChanged = EncoderEnum.Echo;
                    Echo.HandleEncoderEvents(serialNumber, echoColour, memInfo, lightningChanged, encoderChanged, OnEchoChanged, lightingEventArgs);
                    break;
                
                case GenderColour genderColour:
                    lightingEventArgs.Encoder.TypeChanged = EncoderEnum.Gender;
                    Gender.HandleEncoderEvents(serialNumber, genderColour, memInfo, lightningChanged, encoderChanged, OnGenderChanged, lightingEventArgs);
                    break;
                
                case PitchColour pitchColour:
                    lightingEventArgs.Encoder.TypeChanged = EncoderEnum.Pitch;
                    Pitch.HandleEncoderEvents(serialNumber, pitchColour, memInfo, lightningChanged, encoderChanged, OnPitchChanged, lightingEventArgs);
                    break;
                
                case ReverbColour reverbColour:
                    lightingEventArgs.Encoder.TypeChanged = EncoderEnum.Reverb;
                    Reverb.HandleEncoderEvents(serialNumber, reverbColour, memInfo, lightningChanged, encoderChanged, OnReverbChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = encoderLight.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in EncoderLightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}