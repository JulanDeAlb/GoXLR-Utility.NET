using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughButtonStateEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public MuteState Value { get; internal set; }
    }
}