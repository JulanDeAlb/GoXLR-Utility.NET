using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.NoiseGate;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class NoiseGateEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the NoiseGate has been changed
        /// </summary>
        public NoiseGateEnum TypeChanged { get; set; }
        
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
        
        public bool BoolValue { get; set; }
    }
}