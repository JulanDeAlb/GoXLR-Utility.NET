namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class BoolCoughButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}