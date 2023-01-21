namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class ByteDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public byte Value { get; internal set; }
    }
}