using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Megaphone
{
    public class MegaphoneEffectEventArgs : System.EventArgs
    {
        public bool BoolValue { get; internal set; }
        
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public MegaphoneStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Megaphone has been changed
        /// </summary>
        public MegaphoneEnum TypeChanged { get; internal set; }
    }
}