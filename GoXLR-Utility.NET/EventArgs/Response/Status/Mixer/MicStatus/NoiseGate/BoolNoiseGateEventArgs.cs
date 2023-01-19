namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class BoolNoiseGateEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}