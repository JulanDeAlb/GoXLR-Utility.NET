namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class DoubleSampleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public double Value { get; internal set; }
    }
}