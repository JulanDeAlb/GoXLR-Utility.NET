namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects
{
    public class EffectEnabledEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public bool Value { get; set; }
    }
}