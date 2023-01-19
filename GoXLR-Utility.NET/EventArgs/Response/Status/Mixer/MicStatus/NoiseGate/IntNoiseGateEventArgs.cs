namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class IntNoiseGateEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}