using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderFunctionEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public MuteFunction Value { get; internal set; }
    }
}
