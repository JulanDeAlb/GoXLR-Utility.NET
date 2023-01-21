using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender
{
    public class GenderEffectEventArgs : System.EventArgs
    {
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public GenderEnum TypeChanged { get; internal set; }

        public GenderStyle? StyleValue { get; internal set; }
    }
}