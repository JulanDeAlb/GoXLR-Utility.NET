using GoXLR_Utility.NET.Enums.Response.Status.Mixer;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader
{
    public class FaderLightingBaseEventArgs : System.EventArgs
    {
        public FaderColourEventArgs Colour { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public FaderDisplayStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the SamplerBaseLighting has been changed
        /// </summary>
        public SamplerBaseEnum TypeChanged { get; internal set; }
    }
}