using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class SpecificFaderStatusEventArgs : System.EventArgs
    {
        public FaderBase Fader { get; set; }
        
        public string SerialNumber { get; set; }
    }
}