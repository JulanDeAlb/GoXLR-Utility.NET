using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain
{
    public class EqualiserMiniGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which value of the EqualiserMini has been changed
        /// </summary>
        public EqualiserMiniEnum TypeChanged { get; internal set; }
        
        public int Value { get; internal set; }
    }
}