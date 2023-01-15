namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class ScribbleInvertedEventArgs : System.EventArgs
    {
        public bool Inverted { get; set; }
        
        public string SerialNumber { get; set; }
    }
}