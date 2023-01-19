using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings.Display
{
    public class DisplayModeEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public DisplayModeEnum Value { get; internal set; }
    }
}