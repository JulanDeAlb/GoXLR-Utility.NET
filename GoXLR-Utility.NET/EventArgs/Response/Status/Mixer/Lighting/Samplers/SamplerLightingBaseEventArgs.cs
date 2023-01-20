using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Samplers;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Samplers
{
    public class SamplerLightingBaseEventArgs : System.EventArgs
    {
        public SamplerColourEventArgs Colour { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public string StringValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the SamplerBaseLighting has been changed
        /// </summary>
        public SamplerBaseEnum TypeChanged { get; internal set; }
    }
}