using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the Bank has been changed
        /// </summary>
        public BankEnum BankEnum { get; set; }
        
        public SamplePlaybackMode Function { get; set; }
        
        public bool IsPlaying { get; set; }
        
        public SamplePlayOrder Order { get; set; }
        
        //public List<Sample.Sample> Samples { get; set; }
        
        public string SerialNumber { get; set; }
    }
}