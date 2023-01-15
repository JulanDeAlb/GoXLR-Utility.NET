namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains
{
    public class SpecificMicGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}