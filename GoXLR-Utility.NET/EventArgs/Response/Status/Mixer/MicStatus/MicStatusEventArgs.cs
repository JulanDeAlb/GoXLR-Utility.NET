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
        public CompressorEventArgs Compressor { get; internal set; }
        
        public EqualiserEventArgs Equaliser { get; internal set; }
    
        public EqualiserMiniEventArgs EqualiserMini { get; internal set; }
        
        public MicGainEventArgs MicGains { get; internal set; }
        
        public MicTypeEventArgs MicType { get; internal set; }
        
        public NoiseGateEventArgs NoiseGate { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the MicStatus has been changed
        /// </summary>
        public MicStatusEnum TypeChanged { get; internal set; }
    }
}