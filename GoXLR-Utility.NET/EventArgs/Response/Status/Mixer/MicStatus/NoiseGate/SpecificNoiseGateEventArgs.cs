namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class SpecificNoiseGateEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}