using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class SampleEventArgs : System.EventArgs
    { 
        public double DoubleValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Sample has been changed
        /// </summary>
        public SampleEnum TypeChanged { get; internal set; }
    }
}