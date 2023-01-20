namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot
{
    public class BoolRobotEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}