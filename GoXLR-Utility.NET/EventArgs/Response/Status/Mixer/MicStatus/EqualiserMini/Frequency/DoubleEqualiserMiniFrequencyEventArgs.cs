namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    public class DoubleEqualiserMiniFrequencyEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public double Value { get; internal set; }
    }
}