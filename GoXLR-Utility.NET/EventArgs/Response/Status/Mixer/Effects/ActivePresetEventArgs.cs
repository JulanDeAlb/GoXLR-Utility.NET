using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects
{
    public class ActivePresetEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
     
        public EffectBankPresets Value { get; set; }
    }
}