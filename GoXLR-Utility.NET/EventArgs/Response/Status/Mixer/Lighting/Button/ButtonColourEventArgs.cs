using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button
{
    public class ButtonColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Colour has been changed
        /// </summary>
        public TwoColourEnum TypeChanged { get; internal set; }
        
        public string Value { get; internal set; }
    }
}