namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency
{
    public class DoubleEqualiserFrequencyEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public double Value { get; internal set; }
    }
}