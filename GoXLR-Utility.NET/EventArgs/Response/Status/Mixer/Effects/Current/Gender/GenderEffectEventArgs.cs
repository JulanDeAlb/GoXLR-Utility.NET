using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender
{
    public class GenderEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public GenderEnum TypeChanged { get; set; }
        
        public int Value { get; set; }
        
        public GenderStyle? GenderStyle { get; set; }
    }
}