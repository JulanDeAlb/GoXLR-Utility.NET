namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.ButtonDown
{
    public class BoolButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; } 
        
        public bool Value { get; internal set; }
    }
}