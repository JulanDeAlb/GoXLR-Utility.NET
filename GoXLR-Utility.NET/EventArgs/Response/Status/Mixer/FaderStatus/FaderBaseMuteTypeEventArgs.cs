namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseMuteTypeEventArgs : System.EventArgs
    {
        public MuteFunction MuteType { get; set; }
        
        public string SerialNumber { get; set; }
    }
}
