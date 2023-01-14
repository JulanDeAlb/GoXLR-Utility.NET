namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class SpecificFaderScribbleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public string BottomText { get; set; }
        
        public string FileName { get; set; }

        public bool Inverted { get; set; }
        
        public string LeftText { get; set; }
    }
}