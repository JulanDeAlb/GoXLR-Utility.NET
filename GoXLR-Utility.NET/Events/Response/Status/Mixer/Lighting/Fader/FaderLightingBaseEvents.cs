using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Fader
{
    public class FaderLightingBaseEvents
    {
        public TwoColourEvents Colour = new TwoColourEvents();
        
        public event EventHandler<FaderColourEventArgs> OnColourChanged;
        public event EventHandler<FaderStyleEventArgs> OnStyleChanged;
        
        protected internal void HandleEvents(string serialNumber, FaderLightBase fader, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<FaderLightingEventArgs> faderChanged,
            EventHandler<FaderLightingBaseEventArgs> faderXChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Fader.Base = new FaderLightingBaseEventArgs
            {
                SerialNumber = serialNumber
            };
            
            if (memInfo.Name.Equals("Style"))
            {
                lightingEventArgs.Fader.Base.TypeChanged = SamplerBaseEnum.OffStyle;
                lightingEventArgs.Fader.Base.StyleValue = fader.Style;
                
                lightningChanged?.Invoke(this, lightingEventArgs);
                faderChanged?.Invoke(this, lightingEventArgs.Fader);
                faderXChanged?.Invoke(this, lightingEventArgs.Fader.Base);
                OnStyleChanged?.Invoke(this, new FaderStyleEventArgs
                {
                    SerialNumber = serialNumber,
                    Value = fader.Style
                });
            }
            else
            {
                lightingEventArgs.Fader.Base.TypeChanged = SamplerBaseEnum.Colour;
                Colour.HandleFaderEvents(serialNumber, fader.Colour, memInfo, lightningChanged, faderChanged, faderXChanged, OnColourChanged, lightingEventArgs);
            }
        }
    }
}