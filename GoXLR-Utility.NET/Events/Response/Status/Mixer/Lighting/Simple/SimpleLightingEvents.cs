using System;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Simple
{
    public class SimpleLightingEvents
    {
        public event EventHandler<StringSimpleColourEventArgs> OnAccentChanged;
        public event EventHandler<StringSimpleColourEventArgs> OnScribble1Changed;
        public event EventHandler<StringSimpleColourEventArgs> OnScribble2Changed;
        public event EventHandler<StringSimpleColourEventArgs> OnScribble3Changed;
        public event EventHandler<StringSimpleColourEventArgs> OnScribble4Changed;
        public event EventHandler<StringSimpleColourEventArgs> OnGlobalChanged;
        
        protected internal void HandleEvents(string serialNumber, OneColour myClass,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<SimpleColourEventArgs> simpleChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Simple = new SimpleColourEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (myClass)
            {
                case Accent accent:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Accent;
                    lightingEventArgs.Simple.Value = accent.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnAccentChanged?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = accent.ColourOne
                    });
                    break;
                
                case Scribble1 scribble1:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Scribble1;
                    lightingEventArgs.Simple.Value = scribble1.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnScribble1Changed?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble1.ColourOne
                    });
                    break;
                
                case Scribble2 scribble2:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Scribble2;
                    lightingEventArgs.Simple.Value = scribble2.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnScribble2Changed?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble2.ColourOne
                    });
                    break;
                
                case Scribble3 scribble3:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Scribble3;
                    lightingEventArgs.Simple.Value = scribble3.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnScribble3Changed?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble3.ColourOne
                    });
                    break;
                
                case Scribble4 scribble4:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Scribble4;
                    lightingEventArgs.Simple.Value = scribble4.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnScribble4Changed?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble4.ColourOne
                    });
                    break;
                
                case Global global:
                    lightingEventArgs.Simple.TypeChanged = SimpleLightingEnum.Global;
                    lightingEventArgs.Simple.Value = global.ColourOne;
                    
                    lightningChanged?.Invoke(this, lightingEventArgs);
                    simpleChanged?.Invoke(this, lightingEventArgs.Simple);
                    OnGlobalChanged?.Invoke(this, new StringSimpleColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = global.ColourOne
                    });
                    break;
                
                default:
                    var type = myClass.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in SimpleLightEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}