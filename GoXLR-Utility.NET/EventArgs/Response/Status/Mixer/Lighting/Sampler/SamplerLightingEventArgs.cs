using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler
{
    public class SamplerLightingEventArgs : System.EventArgs
    {
        public SamplerLightingBaseEventArgs Base { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the SamplerLighting has been changed
        /// </summary>
        public SamplerEnum TypeChanged { get; internal set; }
    }
}