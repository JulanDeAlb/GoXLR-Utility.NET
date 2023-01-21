using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseScribbleEventArgs : System.EventArgs
    {
        public bool BoolValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Scribble has been changed
        /// </summary>
        public ScribbleEnum TypeChanged { get; internal set; }
    }
}
