using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current
{
    public class CurrentEffectEventArgs : System.EventArgs
    {
        public EchoEffectEventArgs Echo { get; set; }
        
        public GenderEffectEventArgs Gender { get; set; }
        
        public HardTuneEffectEventArgs HardTune { get; set; }
        
        public MegaphoneEffectEventArgs Megaphone { get; set; }
        
        public PitchEffectEventArgs Pitch { get; set; }
        
        public ReverbEffectEventArgs Reverb { get; set; }
        
        public RobotEffectEventArgs Robot { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Effect has been changed
        /// </summary>
        public CurrentEffectEnum TypeChanged { get; set; }
    }
}