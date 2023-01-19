namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb
{
    public class IntReverbEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}