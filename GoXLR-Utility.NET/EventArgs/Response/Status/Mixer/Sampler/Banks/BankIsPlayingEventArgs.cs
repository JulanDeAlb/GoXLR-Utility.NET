namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankIsPlayingEventArgs : System.EventArgs
    {
        public bool IsPlaying { get; set; }
        
        public string SerialNumber { get; set; }
    }
}