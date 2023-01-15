namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain
{
    public class SpecificEqualiserMiniGainEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}