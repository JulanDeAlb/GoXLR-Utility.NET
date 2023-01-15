using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseScribbleEventArgs : System.EventArgs
    {
        public ScribbleBottomTextEventArgs BottomText { get; set; }
        
        public ScribbleFileNameEventArgs FileName { get; set; }
        
        public ScribbleInvertedEventArgs Inverted { get; set; }
        
        public ScribbleLeftTextEventArgs LeftText { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Scribble has been changed
        /// </summary>
        public ScribbleEnum TypeChanged { get; set; }
    }
}
