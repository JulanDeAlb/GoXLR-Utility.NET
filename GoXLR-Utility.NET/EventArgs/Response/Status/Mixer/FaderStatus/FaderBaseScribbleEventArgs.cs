using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseScribbleEventArgs : System.EventArgs
    {
        public FaderScribble Scribble { get; set; }
        
        /// <summary>
        /// Indicating which type of the Scribble has been changed
        /// </summary>
        public ScribbleEnum ScribbleEnum { get; set; }
        
        public string SerialNumber { get; set; }
    }
}
