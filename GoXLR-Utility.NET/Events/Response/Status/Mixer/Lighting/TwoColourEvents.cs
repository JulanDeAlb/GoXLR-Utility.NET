using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting
{
    public class TwoColourEvents
    {
        public event EventHandler<StringDeviceEventArgs> OnColourOneChanged;
        public event EventHandler<StringDeviceEventArgs> OnColourTwoChanged;

        protected internal void HandleFaderEvents(string serialNumber, TwoColour colour, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<FaderLightingEventArgs> faderChanged,
            EventHandler<FaderLightingBaseEventArgs> faderXChanged,
            EventHandler<FaderColourEventArgs> colourChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Fader.Base.Colour = new FaderColourEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "ColourOne":
                    lightingEventArgs.Fader.Base.Colour.TypeChanged = TwoColourEnum.ColourOne;
                    lightingEventArgs.Fader.Base.Colour.Value = colour.ColourOne;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    faderChanged?.Invoke(this, lightingEventArgs.Fader);
                    faderXChanged?.Invoke(this, lightingEventArgs.Fader.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Fader.Base.Colour);
                    OnColourOneChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourOne
                    });
                    break;
                
                case "ColourTwo":
                    lightingEventArgs.Fader.Base.Colour.TypeChanged = TwoColourEnum.ColourTwo;
                    lightingEventArgs.Fader.Base.Colour.Value = colour.ColourTwo;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    faderChanged?.Invoke(this, lightingEventArgs.Fader);
                    faderXChanged?.Invoke(this, lightingEventArgs.Fader.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Fader.Base.Colour);
                    OnColourTwoChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourTwo
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in TwoColourEvents-HandleFaderEvents");
            }
        }
        
        protected internal void HandleButtonEvents(string serialNumber, TwoColour colour, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<ButtonLightingEventArgs> buttonChanged,
            EventHandler<ButtonLightingBaseEventArgs> buttonXChanged,
            EventHandler<ButtonColourEventArgs> colourChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Button.Base.Colour = new ButtonColourEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "ColourOne":
                    lightingEventArgs.Button.Base.Colour.TypeChanged = TwoColourEnum.ColourOne;
                    lightingEventArgs.Button.Base.Colour.Value = colour.ColourOne;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    buttonChanged?.Invoke(this, lightingEventArgs.Button);
                    buttonXChanged?.Invoke(this, lightingEventArgs.Button.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Button.Base.Colour);
                    OnColourOneChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourOne
                    });
                    break;
                
                case "ColourTwo":
                    lightingEventArgs.Button.Base.Colour.TypeChanged = TwoColourEnum.ColourTwo;
                    lightingEventArgs.Button.Base.Colour.Value = colour.ColourTwo;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    buttonChanged?.Invoke(this, lightingEventArgs.Button);
                    buttonXChanged?.Invoke(this, lightingEventArgs.Button.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Button.Base.Colour);
                    OnColourTwoChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourTwo
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in TwoColourEvents-HandleButtonEvents");
            }
        }
    }
}