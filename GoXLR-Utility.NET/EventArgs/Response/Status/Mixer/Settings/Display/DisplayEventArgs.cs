using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings.Display
{
    public class DisplayEventArgs : System.EventArgs
    {
        public DisplayModeEnum DisplayMode { get; set; }
        
        /// <summary>
        /// Indicating which type of the GuiDisplay has been changed
        /// </summary>
        public GuiDisplayEnum GuiDisplayEnum { get; set; }
        
        public string SerialNumber { get; set; }
    }
}