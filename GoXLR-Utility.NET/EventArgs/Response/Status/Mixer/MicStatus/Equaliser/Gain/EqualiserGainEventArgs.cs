using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    public class EqualiserGainEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which value of the Equaliser has been changed
        /// </summary>
        public EqualiserEnum ValueChanged { get; set; }
        
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}