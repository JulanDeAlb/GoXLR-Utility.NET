using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class FaderScribbleEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which of the Fader Scribble has been changed
        /// </summary>
        public FaderEnum FaderEnum { get; set; }
        
        /// <summary>
        /// Indicating which type of the Fader Scribble has been changed
        /// </summary>
        public ScribbleEnum ScribbleEnum { get; set; }
        
        public FaderScribble Scribble { get; set; }

        public string SerialNumber { get; set; }
    }
}