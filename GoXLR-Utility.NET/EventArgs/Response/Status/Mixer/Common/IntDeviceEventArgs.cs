namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class IntDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}