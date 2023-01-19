using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains
{
    public class MicGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the MicGains has been changed
        /// </summary>
        public MicrophoneType TypeChanged { get; internal set; }
        
        public int Value { get; internal set; }
    }
}