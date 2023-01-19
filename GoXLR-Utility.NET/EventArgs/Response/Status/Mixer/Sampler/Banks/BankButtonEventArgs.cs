using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankButtonEventArgs : System.EventArgs
    {
        public BankBaseEventArgs BankBase { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Button has been changed
        /// </summary>
        public BankButtonEnum TypeChanged { get; internal set; }
    }
}