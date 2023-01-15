namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    public class SpecificEqualiserGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}