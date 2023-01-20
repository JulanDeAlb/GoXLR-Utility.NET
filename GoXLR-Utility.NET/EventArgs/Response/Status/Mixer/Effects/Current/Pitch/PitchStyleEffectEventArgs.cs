using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch
{
    public class PitchStyleEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public PitchStyle Value { get; internal set; }
    }
}