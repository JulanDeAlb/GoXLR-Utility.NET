namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects
{
    public class BoolEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}