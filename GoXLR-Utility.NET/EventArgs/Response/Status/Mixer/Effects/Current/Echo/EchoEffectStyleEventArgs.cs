using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo
{
    public class EchoEffectStyleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public EchoStyle Value { get; internal set; }
    }
}