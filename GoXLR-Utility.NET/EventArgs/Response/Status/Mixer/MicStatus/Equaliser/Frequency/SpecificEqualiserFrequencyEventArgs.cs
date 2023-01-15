namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency
{
    public class SpecificEqualiserFrequencyEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public double Value { get; set; }
    }
}