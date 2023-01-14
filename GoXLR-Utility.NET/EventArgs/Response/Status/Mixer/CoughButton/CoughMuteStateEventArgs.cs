using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughMuteStateEventArgs : System.EventArgs
    {
        public MuteState MuteState { get; set; }
        public string SerialNumber { get; set; }
    }
}