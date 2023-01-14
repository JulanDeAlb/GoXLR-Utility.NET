using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings.GuiDisplay;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings.Display
{
    /// <summary>
    /// <seealso cref="GuiDisplay"/>
    /// </summary>
    public class GuiDisplayEvents
    {
        public event EventHandler<DisplayEventArgs> OnDisplayChanged;

        public event EventHandler<SpecificDisplayEventArgs> OnCompressorChanged;

        public event EventHandler<SpecificDisplayEventArgs> OnEqualiserChanged;

        public event EventHandler<SpecificDisplayEventArgs> OnEqualiserFineChanged;

        public event EventHandler<SpecificDisplayEventArgs> OnGateChanged;

        protected internal void HandleEvents(string serialNumber, GuiDisplay guiDisplay, MemberInfo memInfo)
        {
            var displayEventArgs = new DisplayEventArgs
            {
                SerialNumber = serialNumber
            };
            
            var specDisplayEventArgs = new SpecificDisplayEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Compressor":
                    displayEventArgs.GuiDisplayEnum = GuiDisplayEnum.Compressor;
                    displayEventArgs.DisplayMode = specDisplayEventArgs.DisplayMode = guiDisplay.Compressor;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnCompressorChanged?.Invoke(this, specDisplayEventArgs);
                    break;
                
                case "Equaliser":
                    displayEventArgs.GuiDisplayEnum = GuiDisplayEnum.Equaliser;
                    displayEventArgs.DisplayMode = specDisplayEventArgs.DisplayMode = guiDisplay.Equaliser;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnEqualiserChanged?.Invoke(this, specDisplayEventArgs);
                    break;
                
                case "EqualiserFine":
                    displayEventArgs.GuiDisplayEnum = GuiDisplayEnum.EqualiserFine;
                    displayEventArgs.DisplayMode = specDisplayEventArgs.DisplayMode = guiDisplay.EqualiserFine;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnEqualiserFineChanged?.Invoke(this, specDisplayEventArgs);
                    break;
                
                case "Gate":
                    displayEventArgs.GuiDisplayEnum = GuiDisplayEnum.Gate;
                    displayEventArgs.DisplayMode = specDisplayEventArgs.DisplayMode = guiDisplay.Gate;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnGateChanged?.Invoke(this, specDisplayEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in GuiDisplay");
            }
        }
    }
}