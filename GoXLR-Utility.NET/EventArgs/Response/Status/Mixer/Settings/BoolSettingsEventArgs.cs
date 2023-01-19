namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings
{
    public class BoolSettingsEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public bool Value { get; internal set; }
    }
}