using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus
{
    public class MicTypeEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public MicrophoneType Value { get; internal set; }
    }
}