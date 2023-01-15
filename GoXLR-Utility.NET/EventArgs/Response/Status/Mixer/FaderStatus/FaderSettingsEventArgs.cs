using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderSettingsEventArgs : System.EventArgs
    {
        public FaderBase Fader { get; set; }
        
        /// <summary>
        /// Indicating which of the FaderSettings has been changed
        /// </summary>
        public FaderSettingsEnum FaderSettingsEnum { get; set; }

        public string SerialNumber { get; set; }
    }
}