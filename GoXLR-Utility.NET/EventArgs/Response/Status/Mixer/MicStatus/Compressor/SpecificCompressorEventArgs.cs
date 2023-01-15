namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor
{
    public class SpecificCompressorEventArgs : System.EventArgs
    {
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}