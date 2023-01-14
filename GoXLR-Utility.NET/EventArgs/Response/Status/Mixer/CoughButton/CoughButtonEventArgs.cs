using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.CoughButton;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public CoughButtonEnum ValueChanged { get; internal set; }
        
        public bool IsToggled { get; internal set; }
        
        public MuteState MuteState { get; internal set; }
        
        public MuteFunction MuteFunction { get; internal set; }
    }
}