using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneStyleEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public HardTuneStyle Value { get; internal set; }
    }
}