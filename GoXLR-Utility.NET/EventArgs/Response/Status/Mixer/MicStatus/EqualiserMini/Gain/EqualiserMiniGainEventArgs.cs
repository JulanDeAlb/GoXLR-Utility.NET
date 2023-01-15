using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain
{
    public class EqualiserMiniGainEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which value of the EqualiserMini has been changed
        /// </summary>
        public EqualiserMiniEnum ValueChanged { get; set; }
        
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}