using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughButtonFunctionEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public MuteFunction Value { get; internal set; }
    }
}