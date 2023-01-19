using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot
{
    public class RobotEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public RobotEnum TypeChanged { get; set; }
        
        public int IntValue { get; set; }
        
        public bool BoolValue { get; set; }
        
        public RobotStyle StyleValue { get; set; }
    }
}