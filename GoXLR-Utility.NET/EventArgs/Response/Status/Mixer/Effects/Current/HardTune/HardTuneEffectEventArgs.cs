using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune
{
    public class HardTuneEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the HardTune has been changed
        /// </summary>
        public HardTuneEnum TypeChanged { get; set; }
        
        public int IntValue { get; set; }
        
        public bool? BoolValue { get; set; }
        
        public HardTuneSource SourceValue { get; set; }
        
        public HardTuneStyle StyleValue { get; set; }
    }
}