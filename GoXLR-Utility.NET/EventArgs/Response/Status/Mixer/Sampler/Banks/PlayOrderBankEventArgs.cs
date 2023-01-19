using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class PlayOrderBankEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public SamplePlayOrder Value { get; internal set; }
    }
}