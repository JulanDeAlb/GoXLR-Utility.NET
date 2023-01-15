using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample
{
    public class SampleEventArgs : System.EventArgs
    {
        public SpecificStringSampleEventArgs Name { get; set; }
        
        public SpecificDoubleSampleEventArgs Pct { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Sample has been changed
        /// </summary>
        public SampleEnum TypeChanged { get; set; }
    }
}