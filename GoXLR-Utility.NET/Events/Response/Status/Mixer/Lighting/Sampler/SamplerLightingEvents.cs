using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Sampler
{
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
}