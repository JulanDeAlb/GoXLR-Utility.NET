namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels
{
    public class SByteLevelEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public sbyte Value { get; internal set; }
    }
}