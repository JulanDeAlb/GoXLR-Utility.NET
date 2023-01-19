using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Gender
{
    public class GenderEffectStyleEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public GenderStyle Value { get; set; }
    }
}