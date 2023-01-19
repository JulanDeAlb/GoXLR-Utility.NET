using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankBaseEventArgs : System.EventArgs
    {
        public SamplePlaybackMode? Function { get; internal set; }
        
        public bool IsPlaying { get; internal set; }
        
        public SamplePlayOrder? Order { get; internal set; }
        
        public BankSampleEventArgs SampleList { get; internal set; }
        
        public SampleEventArgs SampleValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }

        /// <summary>
        /// Indicating which type of the BankButtonBase has been changed
        /// </summary>
        public BankBaseEnum TypeChanged { get; internal set; }
    }
}