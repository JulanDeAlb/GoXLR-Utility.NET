using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.HardTune;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Pitch;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Reverb;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current
{
    public class CurrentEffectEventArgs : System.EventArgs
    {
        public EchoEffectEventArgs Echo { get; internal set; }
        
        public GenderEffectEventArgs Gender { get; internal set; }
        
        public HardTuneEffectEventArgs HardTune { get; internal set; }
        
        public MegaphoneEffectEventArgs Megaphone { get; internal set; }
        
        public PitchEffectEventArgs Pitch { get; internal set; }
        
        public ReverbEffectEventArgs Reverb { get; internal set; }
        
        public RobotEffectEventArgs Robot { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Effect has been changed
        /// </summary>
        public CurrentEffectEnum TypeChanged { get; internal set; }
    }
}