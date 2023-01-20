namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class StringDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string Value { get; internal set; }
    }
}