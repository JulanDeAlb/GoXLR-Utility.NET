namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels.Volumes
{
    public class SpecificVolumeChangedEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
            
        public byte Volume { get; internal set; }
    }
}