using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FadersEventArgs : System.EventArgs
    {
        public FaderSettingsEventArgs Fader { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which of the Faders has been changed
        /// </summary>
        public FaderEnum TypeChanged { get; internal set; }
    }
}