using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini
{
    public class EqualiserMiniEventArgs : System.EventArgs
    {
        public EqualiserMiniFrequencyEventArgs FrequencyMini { get; internal set; }
        
        public EqualiserMiniGainEventArgs GainMini { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the EqualiserMini has been changed
        /// </summary>
        public EqualiserTypeEnum TypeChanged { get; internal set; }
    }
}