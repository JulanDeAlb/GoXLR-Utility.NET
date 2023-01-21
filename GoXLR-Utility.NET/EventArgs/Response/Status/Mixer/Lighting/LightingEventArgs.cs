using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting
{
    public class LightingEventArgs : System.EventArgs
    {
        public ButtonLightingEventArgs Button { get; internal set; }
        
        public EncoderLightingEventArgs Encoder { get; internal set; }
            
        public FaderLightingEventArgs Fader { get; internal set; }
        
        public SamplerLightingEventArgs Sampler { get; internal set;}
        
        public string SerialNumber { get; internal set;}
        
        public SimpleColourEventArgs Simple { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Lighting has been changed
        /// </summary>
        public LightingEnum TypeChanged { get; internal set; }
    }
}