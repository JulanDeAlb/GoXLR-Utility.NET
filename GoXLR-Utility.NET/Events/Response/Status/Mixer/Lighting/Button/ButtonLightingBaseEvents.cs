using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Button
{
    public class ButtonLightingBaseEvents
    {
        public TwoColourEvents Colour = new TwoColourEvents();
        
        public event EventHandler<ButtonColourEventArgs> OnColourChanged;
        public event EventHandler<StringDeviceEventArgs> OnOffStyleChanged;
        
        protected internal void HandleEvents(string serialNumber, ButtonLightBase button, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<ButtonLightingEventArgs> buttonChanged,
            EventHandler<ButtonLightingBaseEventArgs> buttonXChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Button.Base = new ButtonLightingBaseEventArgs
            {
                SerialNumber = serialNumber
            };
            
            if (memInfo.Name.Equals("OffStyle"))
            {
                lightingEventArgs.Button.Base.TypeChanged = ButtonLightBaseEnum.OffStyle;
                lightingEventArgs.Button.Base.StringValue = button.OffStyle;
                
                lightningChanged?.Invoke(this, lightingEventArgs);
                buttonChanged?.Invoke(this, lightingEventArgs.Button);
                buttonXChanged?.Invoke(this, lightingEventArgs.Button.Base);
                OnOffStyleChanged?.Invoke(this, new StringDeviceEventArgs
                {
                    SerialNumber = serialNumber,
                    Value = button.OffStyle
                });
            }
            else
            {
                lightingEventArgs.Button.Base.TypeChanged = ButtonLightBaseEnum.Colour;
                Colour.HandleButtonEvents(serialNumber, button.Colour, memInfo, lightningChanged, buttonChanged, buttonXChanged, OnColourChanged, lightingEventArgs);
            }
        }
    }
}