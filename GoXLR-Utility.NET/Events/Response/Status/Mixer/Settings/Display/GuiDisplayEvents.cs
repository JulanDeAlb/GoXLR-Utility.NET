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

        public event EventHandler<DisplayModeEventArgs> OnCompressorChanged;

        public event EventHandler<DisplayModeEventArgs> OnEqualiserChanged;

        public event EventHandler<DisplayModeEventArgs> OnEqualiserFineChanged;

        public event EventHandler<DisplayModeEventArgs> OnGateChanged;

        protected internal void HandleEvents(string serialNumber, GuiDisplay guiDisplay, MemberInfo memInfo)
        {
            var displayEventArgs = new DisplayEventArgs
            {
                SerialNumber = serialNumber
            };
            
            var displayModeEventArgs = new DisplayModeEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Compressor":
                    displayEventArgs.TypeChanged = GuiDisplayEnum.Compressor;
                    displayEventArgs.Value = displayModeEventArgs.Value = guiDisplay.Compressor;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnCompressorChanged?.Invoke(this, displayModeEventArgs);
                    break;
                
                case "Equaliser":
                    displayEventArgs.TypeChanged = GuiDisplayEnum.Equaliser;
                    displayEventArgs.Value = displayModeEventArgs.Value = guiDisplay.Equaliser;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnEqualiserChanged?.Invoke(this, displayModeEventArgs);
                    break;
                
                case "EqualiserFine":
                    displayEventArgs.TypeChanged = GuiDisplayEnum.EqualiserFine;
                    displayEventArgs.Value = displayModeEventArgs.Value = guiDisplay.EqualiserFine;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnEqualiserFineChanged?.Invoke(this, displayModeEventArgs);
                    break;
                
                case "Gate":
                    displayEventArgs.TypeChanged = GuiDisplayEnum.Gate;
                    displayEventArgs.Value = displayModeEventArgs.Value = guiDisplay.Gate;
                    OnDisplayChanged?.Invoke(this, displayEventArgs);
                    OnGateChanged?.Invoke(this, displayModeEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in GuiDisplay");
            }
        }
    }
}