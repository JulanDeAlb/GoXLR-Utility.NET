using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button
{
    public class ButtonLightingBaseEventArgs : System.EventArgs
    {
        public ButtonColourEventArgs Colour { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the ButtonBaseLighting has been changed
        /// </summary>
        public ButtonLightBaseEnum TypeChanged { get; internal set; }
    }
}