using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb
{
    public class ReverbEffectEventArgs : System.EventArgs
    {
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public ReverbStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Reverb has been changed
        /// </summary>
        public ReverbEnum TypeChanged { get; internal set; }
    }
}