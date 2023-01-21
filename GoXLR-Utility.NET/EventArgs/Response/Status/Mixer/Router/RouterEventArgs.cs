using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Router
{
    public class RouterEventArgs : System.EventArgs
    {
        public InputDevice Input { get; internal set; }
        
        public OutputDevice Output { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}