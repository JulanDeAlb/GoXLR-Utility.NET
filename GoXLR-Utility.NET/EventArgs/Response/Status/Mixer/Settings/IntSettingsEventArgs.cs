namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings
{
    public class IntSettingsEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}