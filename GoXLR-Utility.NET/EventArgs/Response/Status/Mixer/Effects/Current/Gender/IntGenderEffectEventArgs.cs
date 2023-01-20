namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender
{
    public class IntGenderEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}