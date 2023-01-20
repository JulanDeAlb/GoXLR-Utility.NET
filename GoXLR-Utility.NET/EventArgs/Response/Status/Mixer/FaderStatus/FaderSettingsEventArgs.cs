using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderSettingsEventArgs : System.EventArgs
    {
        public FaderChannelEnum ChannelValue { get; internal set; }

        public MuteFunction FunctionValue { get; internal set; }
        
        public FaderScribbleEventArgs Scribble { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public MuteState? StateValue { get; internal set; }
        
        /// <summary>
        /// Indicating which of the FaderSettings has been changed
        /// </summary>
        public FaderSettingsEnum TypeChanged { get; set; }
    }
}