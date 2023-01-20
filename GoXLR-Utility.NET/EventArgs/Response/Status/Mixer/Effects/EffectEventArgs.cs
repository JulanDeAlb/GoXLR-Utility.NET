using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.PresetNames;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects
{
    public class EffectEventArgs : System.EventArgs
    {
        public ActivePresetEventArgs ActivePreset { get; set; }
        
        public CurrentEffectEventArgs Current { get; set; }
        
        public BoolEffectEventArgs Enabled { get; set; }
        
        public PresetNameEventArgs PresetNames { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Effects has been changed
        /// </summary>
        public EffectEnum TypeChanged { get; set; }
    }
}