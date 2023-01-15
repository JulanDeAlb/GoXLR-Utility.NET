using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus
{
    public class MicStatusEventArgs : System.EventArgs
    {
        public CompressorEventArgs Compressor { get; set; }
        
        public EqualiserEventArgs Equaliser { get; set; }
    
        public EqualiserMiniEventArgs EqualiserMini { get; set; }
        
        public MicGainEventArgs MicGains { get; set; }
        
        public MicTypeEventArgs MicType { get; set; }
        
        public NoiseGateEventArgs NoiseGate { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the MicStatus has been changed
        /// </summary>
        public MicStatusEnum TypeChanged { get; set; }
    }
}