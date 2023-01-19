using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class MegaphoneStyleEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public MegaphoneStyle Value { get; set; }
    }
}