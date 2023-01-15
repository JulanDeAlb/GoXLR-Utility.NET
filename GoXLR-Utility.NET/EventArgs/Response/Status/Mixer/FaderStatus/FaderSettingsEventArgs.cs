using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderSettingsEventArgs : System.EventArgs
    {
        public FaderChannelEventArgs Channel { get; set; }
        
        public FaderMuteTypeEventArgs MuteType { get; set; }
        
        public FaderMuteStateEventArgs MuteState { get; set; }
        
        public FaderScribbleEventArgs Scribble { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which of the FaderSettings has been changed
        /// </summary>
        public FaderSettingsEnum TypeChanged { get; set; }
    }
}