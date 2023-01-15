namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class SpecificDoubleSampleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public double Value { get; set; }
    }
}