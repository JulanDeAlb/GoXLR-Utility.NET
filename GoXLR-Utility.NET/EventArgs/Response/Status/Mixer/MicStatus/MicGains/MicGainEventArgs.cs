using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.MicGains;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains
{
    public class MicGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the MicGains has been changed
        /// </summary>
        public MicGainEnum TypeChanged { get; set; }
        
        public int Value { get; set; }
    }
}