using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Compressor;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor
{
    public class CompressorEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Compressor has been changed
        /// </summary>
        public CompressorEnum TypeChanged { get; internal set; }
        
        public int Value { get; internal set; }
    }
}