using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankFunctionEventArgs : System.EventArgs
    {
        public SamplePlaybackMode Function { get; set; }
        
        public string SerialNumber { get; set; }
    }
}