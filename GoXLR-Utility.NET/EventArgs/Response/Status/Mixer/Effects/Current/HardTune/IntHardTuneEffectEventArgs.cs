namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class IntHardTuneEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}