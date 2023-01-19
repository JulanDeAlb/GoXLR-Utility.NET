using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankPlaybackEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public SamplePlaybackMode Value { get; internal set; }
    }
}