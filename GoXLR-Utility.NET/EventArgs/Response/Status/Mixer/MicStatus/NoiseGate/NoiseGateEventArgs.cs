using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class NoiseGateEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the NoiseGate has been changed
        /// </summary>
        public NoiseGateEnum TypeChanged { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
        
        public bool BoolValue { get; internal set; }
    }
}