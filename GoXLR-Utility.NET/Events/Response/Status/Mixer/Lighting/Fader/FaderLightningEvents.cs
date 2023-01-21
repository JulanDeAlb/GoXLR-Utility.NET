using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Faders;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Fader
{
    public class FaderLightingEvents
    {
        public FaderLightingBaseEvents A = new FaderLightingBaseEvents();
        public FaderLightingBaseEvents B = new FaderLightingBaseEvents();
        public FaderLightingBaseEvents C = new FaderLightingBaseEvents();
        public FaderLightingBaseEvents D = new FaderLightingBaseEvents();
        
        public event EventHandler<FaderLightingBaseEventArgs> OnFaderAChanged;
        public event EventHandler<FaderLightingBaseEventArgs> OnFaderBChanged;
        public event EventHandler<FaderLightingBaseEventArgs> OnFaderCChanged;
        public event EventHandler<FaderLightingBaseEventArgs> OnFaderDChanged;

        protected internal void HandleEvents(string serialNumber, FaderLightBase lightBase, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<FaderLightingEventArgs> faderChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Fader = new FaderLightingEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (lightBase)
            {
                case FaderA faderA:
                    lightingEventArgs.Fader.TypeChanged = FaderEnum.A;
                    A.HandleEvents(serialNumber, faderA, memInfo, lightningChanged, faderChanged, OnFaderAChanged, lightingEventArgs);
                    break;
                
                case FaderB faderB:
                    lightingEventArgs.Fader.TypeChanged = FaderEnum.B;
                    B.HandleEvents(serialNumber, faderB, memInfo, lightningChanged, faderChanged, OnFaderBChanged, lightingEventArgs);
                    break;
                
                case FaderC faderC:
                    lightingEventArgs.Fader.TypeChanged = FaderEnum.C;
                    C.HandleEvents(serialNumber, faderC, memInfo, lightningChanged, faderChanged, OnFaderCChanged, lightingEventArgs);
                    break;
                
                case FaderD faderD:
                    lightingEventArgs.Fader.TypeChanged = FaderEnum.D;
                    D.HandleEvents(serialNumber, faderD, memInfo, lightningChanged, faderChanged, OnFaderDChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = lightBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in FaderLightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}