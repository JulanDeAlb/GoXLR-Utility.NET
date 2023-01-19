using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class SamplerBanksEventArgs : System.EventArgs
    {
        public BankButtonEventArgs BankButton { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which one of the Sampler has been changed
        /// </summary>
        public SamplerBank TypeChanged { get; internal set; }
    }
}