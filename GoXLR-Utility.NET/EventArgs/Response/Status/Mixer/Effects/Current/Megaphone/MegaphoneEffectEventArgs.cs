using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class MegaphoneEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Megaphone has been changed
        /// </summary>
        public MegaphoneEnum TypeChanged { get; set; }
        
        public int IntValue { get; set; }
        
        public bool BoolValue { get; set; }
        
        public MegaphoneStyle StyleValue { get; set; }
    }
}