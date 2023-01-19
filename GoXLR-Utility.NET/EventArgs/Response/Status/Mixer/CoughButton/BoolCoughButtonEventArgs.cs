namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class BoolCoughButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public bool Value { get; set; }
    }
}