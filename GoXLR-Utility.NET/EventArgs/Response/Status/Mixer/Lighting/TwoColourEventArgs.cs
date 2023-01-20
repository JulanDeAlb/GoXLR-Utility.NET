using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting
{
    public class TwoColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the TwoColour has been changed
        /// </summary>
        public TwoColourEnum TypeChanged { get; internal set; }
    }
}