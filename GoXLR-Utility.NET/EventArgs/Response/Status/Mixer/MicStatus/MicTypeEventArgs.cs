using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus
{
    public class MicTypeEventArgs : System.EventArgs
    {
        public MicrophoneType MicrophoneType { get; set; }
        
        public string SerialNumber { get; set; }
    }
}