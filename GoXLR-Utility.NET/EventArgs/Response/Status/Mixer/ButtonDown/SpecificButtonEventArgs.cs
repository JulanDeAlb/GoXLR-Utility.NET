namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.ButtonDown
{
    public class SpecificButtonEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool IsButtonDown { get; internal set; }
    }
}