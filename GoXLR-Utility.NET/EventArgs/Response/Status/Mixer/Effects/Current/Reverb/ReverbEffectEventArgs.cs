using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb
{
    public class ReverbEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public ReverbEnum TypeChanged { get; set; }
        
        public int IntValue { get; set; }
        
        public ReverbStyle StyleValue { get; set; }
    }
}