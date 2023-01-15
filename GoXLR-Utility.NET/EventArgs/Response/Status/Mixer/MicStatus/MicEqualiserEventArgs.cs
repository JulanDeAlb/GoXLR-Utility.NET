using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus
{
    public class MicEqualiserEventArgs : System.EventArgs
    {
        public EqualiserEnum EqualiserValueEnum
        
        /// <summary>
        /// Indicating which type of the Equaliser has been changed
        /// </summary>
        public EqualiserTypeEnum EqualiserTypeEnum { get; set; }
        
        public string SerialNumber { get; set; }
    }
}