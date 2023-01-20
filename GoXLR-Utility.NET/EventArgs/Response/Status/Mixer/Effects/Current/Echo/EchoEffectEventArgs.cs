using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo
{
    public class EchoEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }

        /// <summary>
        /// Indicating which type of the Echo has been changed
        /// </summary>
        public EchoEnum TypeChanged { get; internal set; }
        
        public int Value { get; internal set; }
        
        public EchoStyle? StyleValue { get; internal set; }
    }
}