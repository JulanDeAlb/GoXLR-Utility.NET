namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor
{
    public class IntCompressorEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public int Value { get; internal set; }
    }
}