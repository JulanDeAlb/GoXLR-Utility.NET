using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Samplers;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting
{
    public class LightingEventArgs : System.EventArgs
    {
        public SamplerLightingEventArgs Sampler { get; internal set;}
        
        public string SerialNumber { get; internal set;}
        
        public SimpleColourEventArgs Simple { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Lighting has been changed
        /// </summary>
        public LightingEnum TypeChanged { get; internal set; }
    }
}