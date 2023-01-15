namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate
{
    public class SpecificBoolNoiseGateEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public bool Value { get; set; }
    }
}