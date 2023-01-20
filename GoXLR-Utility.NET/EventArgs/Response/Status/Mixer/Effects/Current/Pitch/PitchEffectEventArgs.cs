using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch
{
    public class PitchEffectEventArgs : System.EventArgs
    {
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public PitchStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Pitch has been changed
        /// </summary>
        public PitchEnum TypeChanged { get; internal set; }
    }
}