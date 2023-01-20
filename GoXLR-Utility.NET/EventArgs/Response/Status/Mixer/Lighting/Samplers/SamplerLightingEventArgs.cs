using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Samplers;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Samplers
{
    public class SamplerLightingEventArgs : System.EventArgs
    {
        public SamplerLightingBaseEventArgs Base { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the SamplerLighting has been changed
        /// </summary>
        public SamplerBaseEnum TypeChanged { get; internal set; }
    }
}