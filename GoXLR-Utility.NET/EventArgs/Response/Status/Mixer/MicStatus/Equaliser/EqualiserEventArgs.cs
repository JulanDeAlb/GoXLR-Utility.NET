using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser
{
    public class EqualiserEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the Equaliser has been changed
        /// </summary>
        public EqualiserTypeEnum TypeChanged { get; set; }
        
        public EqualiserGainEventArgs Gain { get; set; }
        
        public EqualiserFrequencyEventArgs Frequency { get; set; }
        
        public string SerialNumber { get; set; }
    }
}