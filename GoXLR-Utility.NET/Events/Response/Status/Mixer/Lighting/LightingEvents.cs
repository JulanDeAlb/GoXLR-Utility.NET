using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting
{
    public class LightingEvents
    {
        public ButtonLightingEvents Button = new ButtonLightingEvents();
        public EncoderLightingEvents Encoder = new EncoderLightingEvents();
        public FaderLightingEvents Fader = new FaderLightingEvents();
        public SamplerLightingEvents Sampler = new SamplerLightingEvents();
        public SimpleLightingEvents Simple = new SimpleLightingEvents();
        
        public event EventHandler<LightingEventArgs> OnLightningChanged;
        public event EventHandler<ButtonLightingEventArgs> OnButtonsChanged;
        public event EventHandler<EncoderLightingEventArgs> OnEncodersChanged;
        public event EventHandler<FaderLightingEventArgs> OnFaderChanged;
        public event EventHandler<SamplerLightingEventArgs> OnSamplerChanged;
        public event EventHandler<SimpleColourEventArgs> OnSimpleChanged;

        protected internal void HandleEvents(string serialNumber, object lighting, object childObject, MemberInfo memInfo)
        {
            var lightingEventArgs = new LightingEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (lighting)
            {
                case ButtonLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Buttons;
                    Button.HandleEvents(serialNumber, (ButtonLightBase) childObject, memInfo, OnLightningChanged, OnButtonsChanged, lightingEventArgs);
                    break;
                
                case EncoderLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Encoders;
                    Encoder.HandleEvents(serialNumber, (ThreeColour) childObject, memInfo, OnLightningChanged, OnEncodersChanged, lightingEventArgs);
                    break;
                
                case FaderLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Faders;
                    Fader.HandleEvents(serialNumber, (FaderLightBase) childObject, memInfo, OnLightningChanged, OnFaderChanged, lightingEventArgs);
                    break;
                
                case SamplerLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Sampler;
                    Sampler.HandleEvents(serialNumber, (SamplerLightBase) childObject, memInfo, OnLightningChanged, OnSamplerChanged, lightingEventArgs);
                    break;
                
                case SimpleLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Simple;
                    Simple.HandleEvents(serialNumber, (OneColour) childObject, OnLightningChanged, OnSimpleChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = lighting.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in LightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}