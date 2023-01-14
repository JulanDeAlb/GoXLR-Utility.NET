using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings.Display
{
    public class SpecificDisplayEventArgs : System.EventArgs
    {
        public DisplayModeEnum DisplayMode { get; set; }
        
        public string SerialNumber { get; set; }
    }
}