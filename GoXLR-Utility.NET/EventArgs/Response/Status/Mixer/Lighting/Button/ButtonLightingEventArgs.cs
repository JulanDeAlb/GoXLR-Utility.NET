using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button
{
    public class ButtonLightingEventArgs : System.EventArgs
    {
        public ButtonLightingBaseEventArgs Base { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the ButtonLighting has been changed
        /// </summary>
        public ButtonLightEnum TypeChanged { get; internal set; }
    }
}