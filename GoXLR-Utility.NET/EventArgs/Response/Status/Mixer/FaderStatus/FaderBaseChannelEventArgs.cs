using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseChannelEventArgs : System.EventArgs
    {
        public FaderChannelEnum Channel { get; set; }
        
        public string SerialNumber { get; set; }
    }
}
