namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class SByteDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public sbyte Value { get; internal set; }
    }
}