using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble
{
    public class FaderScribbleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public FaderName FaderName { get; set; }
        
        public string BottomText { get; set; }
        
        public string FileName { get; set; }

        public bool Inverted { get; set; }
        
        public string LeftText { get; set; }
    }
}