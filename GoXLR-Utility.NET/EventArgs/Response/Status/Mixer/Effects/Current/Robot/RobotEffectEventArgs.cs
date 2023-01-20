using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot
{
    public class RobotEffectEventArgs : System.EventArgs
    {
        public bool BoolValue { get; internal set; }
        
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }
        
        public RobotStyle StyleValue { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Robot has been changed
        /// </summary>
        public RobotEnum TypeChanged { get; internal set; }
    }
}