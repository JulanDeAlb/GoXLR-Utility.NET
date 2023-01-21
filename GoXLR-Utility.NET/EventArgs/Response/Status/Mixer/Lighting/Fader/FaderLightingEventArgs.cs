using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader
{
    public class FaderLightingEventArgs : System.EventArgs
    {
        public FaderLightingBaseEventArgs Base { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Fader has been changed
        /// </summary>
        public FaderEnum TypeChanged { get; internal set; }
    }
}