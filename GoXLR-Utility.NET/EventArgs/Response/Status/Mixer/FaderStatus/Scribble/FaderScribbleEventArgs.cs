namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class FaderScribbleEventArgs : System.EventArgs
    {
        public FaderBaseScribbleEventArgs FaderBase { get; internal set; }

        public string SerialNumber { get; internal set; }
    }
}