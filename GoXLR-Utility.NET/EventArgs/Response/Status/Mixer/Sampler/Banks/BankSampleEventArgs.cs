using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankSampleEventArgs
    {
        public int Index { get; internal set; }
        
        public OpPatchEnum Operation { get; internal set; }
        
        public Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample Sample { get; internal set; }
        
        public string SerialNumber { get; internal set; }
    }
}