namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer
{
    public class ProfileEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string Value { get; internal set; }
    }
}