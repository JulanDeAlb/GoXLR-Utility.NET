namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Robot
{
    public class IntRobotEffectEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}