namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class BoolMegaphoneEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}