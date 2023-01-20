namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common
{
    public class DoubleDeviceEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public double Value { get; internal set; }
    }
}