using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Compressor;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor
{
    public class CompressorEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the Compressor has been changed
        /// </summary>
        public CompressorEnum TypeChanged { get; set; }
        
        public string SerialNumber { get; set; }
        
        public int Value { get; set; }
    }
}