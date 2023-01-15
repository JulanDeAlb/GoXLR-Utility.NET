using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    public class EqualiserMiniFrequencyEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which value of the Equaliser has been changed
        /// </summary>
        public EqualiserMiniEnum ValueChanged { get; set; }
        
        public string SerialNumber { get; set; }
        
        public double Value { get; set; }
    }
}