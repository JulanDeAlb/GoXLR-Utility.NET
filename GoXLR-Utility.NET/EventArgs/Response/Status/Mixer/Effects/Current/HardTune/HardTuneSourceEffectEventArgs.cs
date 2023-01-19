using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneSourceEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public HardTuneSource Value { get; set; }
    }
}