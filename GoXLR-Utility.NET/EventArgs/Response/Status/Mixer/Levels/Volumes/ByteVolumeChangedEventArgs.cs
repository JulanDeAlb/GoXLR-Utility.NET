namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels.Volumes
{
    public class ByteVolumeChangedEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
            
        public byte Value { get; internal set; }
    }
}