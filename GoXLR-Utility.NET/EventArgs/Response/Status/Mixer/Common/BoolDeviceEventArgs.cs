namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class BoolDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}