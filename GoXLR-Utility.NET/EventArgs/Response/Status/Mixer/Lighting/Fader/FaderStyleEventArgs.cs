using GoXLR_Utility.NET.Enums.Response.Status.Mixer;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader
{
    public class FaderStyleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public FaderDisplayStyle Value { get; internal set; }
    }
}