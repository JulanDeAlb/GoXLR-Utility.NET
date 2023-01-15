namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderMuteTypeEventArgs : System.EventArgs
    {
        public MuteFunction Value { get; set; }
        
        public string SerialNumber { get; set; }
    }
}
