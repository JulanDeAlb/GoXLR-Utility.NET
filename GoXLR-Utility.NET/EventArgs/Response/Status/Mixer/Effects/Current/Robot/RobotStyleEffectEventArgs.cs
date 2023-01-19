using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot
{
    public class RobotStyleEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public RobotStyle Value { get; set; }
    }
}