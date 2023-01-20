using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneEffectEventArgs : System.EventArgs
    {
        public bool? BoolValue { get; internal set; }
        
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public HardTuneSource SourceValue { get; internal set; }
        
        public HardTuneStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the HardTune has been changed
        /// </summary>
        public HardTuneEnum TypeChanged { get; internal set; }
    }
}