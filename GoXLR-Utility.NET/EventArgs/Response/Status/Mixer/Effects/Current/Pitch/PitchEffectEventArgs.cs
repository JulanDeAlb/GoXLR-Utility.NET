using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch
{
    public class PitchEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public PitchEnum TypeChanged { get; set; }
        
        public int IntValue { get; set; }
        
        public PitchStyle StyleValue { get; set; }
    }
}