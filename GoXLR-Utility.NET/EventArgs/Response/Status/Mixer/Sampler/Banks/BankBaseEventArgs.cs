using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankBaseEventArgs : System.EventArgs
    {
        public SamplePlaybackMode? Function { get; set; }
        
        public bool IsPlaying { get; set; }
        
        public SamplePlayOrder? Order { get; set; }
        
        public BankSampleEventArgs SampleList { get; set; }
        
        public SampleEventArgs SampleValue { get; set; }
        
        public string SerialNumber { get; set; }

        /// <summary>
        /// Indicating which type of the BankButtonBase has been changed
        /// </summary>
        public BankBaseEnum TypeChanged { get; set; }
    }
}