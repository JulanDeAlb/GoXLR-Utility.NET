using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb
{
    public class ReverbStyleEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public ReverbStyle Value { get; internal set; }
    }
}