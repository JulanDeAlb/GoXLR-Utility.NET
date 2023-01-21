using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Encoder;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Encoder
{
    public class EncoderLightingEventArgs : System.EventArgs
    {
        public ThreeColourEventArgs Colour { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Encoder has been changed
        /// </summary>
        public EncoderEnum TypeChanged { get; internal set; }
    }
}