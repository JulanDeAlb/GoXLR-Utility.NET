using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    public class EqualiserMiniFrequencyEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which value of the Equaliser has been changed
        /// </summary>
        public EqualiserMiniEnum TypeChanged { get; internal set; }
        
        public double Value { get; internal set; }
    }
}