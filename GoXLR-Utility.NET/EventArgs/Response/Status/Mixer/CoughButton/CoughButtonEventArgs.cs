using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.CoughButton;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughButtonEventArgs : System.EventArgs
    {
        public bool BoolValue { get; internal set; }
        
        public MuteFunction FunctionValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public MuteState StateValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the CoughButton has been changed
        /// </summary>
        public CoughButtonEnum TypeChanged { get; internal set; }
    }
}