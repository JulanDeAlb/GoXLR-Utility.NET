using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Sampler
{
    public class SamplerLightingBaseEvents
    {
        public ThreeColourEvents Colour = new ThreeColourEvents();
        
        public event EventHandler<SamplerColourEventArgs> OnColourChanged;
        public event EventHandler<StringDeviceEventArgs> OnOffStyleChanged;
        
        protected internal void HandleEvents(string serialNumber, SamplerLightBase sampler, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<SamplerLightingEventArgs> samplerChanged,
            EventHandler<SamplerLightingBaseEventArgs> samplerXChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Sampler.Base = new SamplerLightingBaseEventArgs
            {
                SerialNumber = serialNumber
            };
            
            if (memInfo.Name.Equals("OffStyle"))
            {
                lightingEventArgs.Sampler.Base.TypeChanged = SamplerBaseEnum.OffStyle;
                lightingEventArgs.Sampler.Base.StringValue = sampler.OffStyle;
                
                lightningChanged?.Invoke(this, lightingEventArgs);
                samplerChanged?.Invoke(this, lightingEventArgs.Sampler);
                samplerXChanged?.Invoke(this, lightingEventArgs.Sampler.Base);
                OnOffStyleChanged?.Invoke(this, new StringDeviceEventArgs
                {
                    SerialNumber = serialNumber,
                    Value = sampler.OffStyle
                });
            }
            else
            {
                lightingEventArgs.Sampler.Base.TypeChanged = SamplerBaseEnum.Colour;
                Colour.HandleSamplerEvents(serialNumber, sampler.Colour, memInfo, lightningChanged, samplerChanged, samplerXChanged, OnColourChanged, lightingEventArgs);
            }
        }
    }
}