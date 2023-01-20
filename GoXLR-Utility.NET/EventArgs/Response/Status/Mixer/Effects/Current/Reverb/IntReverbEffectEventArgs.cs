namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb
{
    public class IntReverbEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}