namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels
{
    public class SpecificLevelEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public sbyte Volume { get; set; }
    }
}