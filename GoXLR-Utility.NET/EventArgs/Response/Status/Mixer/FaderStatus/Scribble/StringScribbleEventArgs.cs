namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class StringScribbleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string Value { get; internal set; }
    }
}