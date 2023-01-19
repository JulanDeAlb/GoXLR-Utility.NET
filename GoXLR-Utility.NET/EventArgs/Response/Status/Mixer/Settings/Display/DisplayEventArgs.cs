using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings.Display
{
    public class DisplayEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the GuiDisplay has been changed
        /// </summary>
        public GuiDisplayEnum TypeChanged { get; internal set; }
        
        public DisplayModeEnum Value { get; internal set; }
    }
}