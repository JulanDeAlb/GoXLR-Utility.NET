using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting
{
    public class ThreeColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the ThreeColour has been changed
        /// </summary>
        public ThreeColourEnum TypeChanged { get; internal set; }
    }
}