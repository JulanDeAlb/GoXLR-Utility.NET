using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Samplers
{
    public class SamplerColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public ThreeColourEnum TypeChanged { get; internal set; }
        
        public string Value { get; internal set; }
    }
}