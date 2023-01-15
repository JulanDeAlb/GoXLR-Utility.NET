using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankSampleEventArgs
    {
        public int Index { get; set; }
        
        public OpPatchEnum Operation { get; set; }
        
        public Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample Sample { get; set; }
        
        public string SerialNumber { get; set; }
    }
}