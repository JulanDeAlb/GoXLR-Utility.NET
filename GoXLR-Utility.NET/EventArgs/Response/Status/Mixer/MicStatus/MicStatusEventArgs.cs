using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus
{
    public class MicStatusEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the MicStatus has been changed
        /// </summary>
        public MicStatusEnum MicStatusEnum { get; set; }
        
        public string SerialNumber { get; set; }
    }
}