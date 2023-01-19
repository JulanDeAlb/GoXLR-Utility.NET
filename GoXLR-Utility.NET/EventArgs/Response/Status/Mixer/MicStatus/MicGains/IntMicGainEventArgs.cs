namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains
{
    public class IntMicGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}