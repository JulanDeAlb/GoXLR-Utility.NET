using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Samplers;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Samplers;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple;
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
        public SimpleLightingEvents Simple = new SimpleLightingEvents();
        public SamplerLightingEvents Sampler = new SamplerLightingEvents();
        
        public event EventHandler<LightingEventArgs> OnLightningChanged; //TODO
        public event EventHandler<System.EventArgs> OnButtosChanged; //TODO
        public event EventHandler<System.EventArgs> OnEncodersChanged; //TODO
        public event EventHandler<System.EventArgs> OnFadersChanged; //TODO
        public event EventHandler<SamplerLightingEventArgs> OnSamplerChanged; //TODO
        public event EventHandler<SimpleColourEventArgs> OnSimpleChanged; //TODO DONE

        protected internal void HandleEvents(string serialNumber, object lighting, object childObject, MemberInfo memInfo)
        {
            var lightingEventArgs = new LightingEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (lighting)
            {
                case ButtonsLight buttons:

                    break;
                
                case EncodersLight encoders:

                    break;
                
                case FadersLight faders:

                    break;
                
                case SamplerLight _:
                    lightingEventArgs.TypeChanged = LightingEnum.Sampler;
                    Sampler.HandleEvents(serialNumber, (SamplerLightBase) childObject, memInfo, OnLightningChanged, OnSamplerChanged, lightingEventArgs);
                    break;
                
                case SimpleLight simple:
                    lightingEventArgs.TypeChanged = LightingEnum.Simple;
                    Simple.HandleEvents(serialNumber, simple, OnLightningChanged, OnSimpleChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = lighting.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in LightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }

    public class SamplerLightingEvents
    {
        public SamplerLightingBaseEvents A = new SamplerLightingBaseEvents();
        public SamplerLightingBaseEvents B = new SamplerLightingBaseEvents();
        public SamplerLightingBaseEvents C = new SamplerLightingBaseEvents();
        
        public event EventHandler<SamplerLightingBaseEventArgs> OnSamplerAChanged;
        public event EventHandler<SamplerLightingBaseEventArgs> OnSamplerBChanged;
        public event EventHandler<SamplerLightingBaseEventArgs> OnSamplerCChanged;

        protected internal void HandleEvents(string serialNumber, SamplerLightBase lightBase, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<SamplerLightingEventArgs> samplerChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Sampler = new SamplerLightingEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (lightBase)
            {
                case SamplerA samplerA:
                    lightingEventArgs.Sampler.TypeChanged = SamplerEnum.SamplerA;
                    A.HandleEvents(serialNumber, samplerA, memInfo, lightningChanged, samplerChanged, OnSamplerAChanged, lightingEventArgs);
                    break;
                
                case SamplerB samplerB:
                    lightingEventArgs.Sampler.TypeChanged = SamplerEnum.SamplerB;
                    B.HandleEvents(serialNumber, samplerB, memInfo, lightningChanged, samplerChanged, OnSamplerBChanged, lightingEventArgs);
                    break;
                
                case SamplerC samplerC:
                    lightingEventArgs.Sampler.TypeChanged = SamplerEnum.SamplerC;
                    C.HandleEvents(serialNumber, samplerC, memInfo, lightningChanged, samplerChanged, OnSamplerCChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = lightBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in SamplerLightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }

    public class SamplerLightingBaseEvents
    {
        public ThreeColourEvents Colour = new ThreeColourEvents();
        
        public event EventHandler<StringDeviceEventArgs> OnOffstyleChanged;
        public event EventHandler<SamplerColourEventArgs> OnColourChanged;
        
        protected internal void HandleEvents(string serialNumber, SamplerLightBase sampler, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<SamplerLightingEventArgs> samplerChanged,
            EventHandler<SamplerLightingBaseEventArgs> samplerAChanged,
            LightingEventArgs lightingEventArgs)
        {
            if (memInfo.Name.Equals("OffStyle"))
            {
                lightingEventArgs.Sampler.Base.TypeChanged = SamplerBaseEnum.OffStyle;
                lightingEventArgs.Sampler.Base.StringValue = sampler.OffStyle;
                
                OnOffstyleChanged?.Invoke(this, new StringDeviceEventArgs
                {
                    SerialNumber = serialNumber,
                    Value = sampler.OffStyle
                });
            }
            else
            {
                lightingEventArgs.Sampler.Base.TypeChanged = SamplerBaseEnum.Colour;
                Colour.HandleSamplerEvents(serialNumber, sampler.Colour, memInfo, lightningChanged, samplerChanged, samplerAChanged, OnColourChanged, lightingEventArgs);
            }
        }
    }
}