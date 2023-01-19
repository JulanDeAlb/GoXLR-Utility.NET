namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class BoolHardTuneEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public bool Value { get; set; }
    }
}