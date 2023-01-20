using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    public class EqualiserGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which value of the Equaliser has been changed
        /// </summary>
        public EqualiserEnum TypeChanged { get; internal set; }
        
        public int Value { get; internal set; }
    }
}