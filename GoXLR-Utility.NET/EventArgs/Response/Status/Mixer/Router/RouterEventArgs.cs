namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Router
{
    public class RouterEventArgs : System.EventArgs
    {
        public InputDevice Input { get; set; }
        
        public bool IsEnabled { get; set; }
        
        public OutputDevice Output { get; set; }
        
        public string SerialNumber { get; set; }
    }
}