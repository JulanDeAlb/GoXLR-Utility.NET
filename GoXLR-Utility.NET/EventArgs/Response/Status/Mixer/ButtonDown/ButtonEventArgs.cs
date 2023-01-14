using GoXLR_Utility.NET.Enums.Response.Status.Mixer.ButtonDown;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.ButtonDown
{
    public class ButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public ButtonEnum Button { get; internal set; }
        
        public bool IsButtonDown { get; internal set; }
    }
}