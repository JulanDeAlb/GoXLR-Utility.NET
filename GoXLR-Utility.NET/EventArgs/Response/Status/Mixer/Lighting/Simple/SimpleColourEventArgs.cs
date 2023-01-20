using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple
{
    public class SimpleColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the SimpleLights has been changed
        /// </summary>
        public SimpleLightingEnum TypeChanged { get; internal set; }
        
        public string Value { get; internal set; }
    }
}