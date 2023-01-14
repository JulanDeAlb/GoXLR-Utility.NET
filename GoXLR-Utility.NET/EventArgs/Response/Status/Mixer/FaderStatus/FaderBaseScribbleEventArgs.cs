using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseScribbleEventArgs : System.EventArgs
    {
        public FaderScribble Scribble { get; set; }
        
        public string SerialNumber { get; set; }
    }
}
