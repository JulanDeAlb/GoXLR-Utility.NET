using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.PresetNames
{
    public class PresetNameEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Presets has been changed
        /// </summary>
        public EffectBankPresets TypeChanged { get; internal set; }

        public string Value { get; internal set; }
    }
}