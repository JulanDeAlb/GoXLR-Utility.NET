using GoXLR_Utility.NET.Models.Response.Status.Mixer;

namespace GoXLR_Utility.NET.EventArgs.Response.Status
{
    public class DevicesEventArgs : System.EventArgs
    { 
        public Device DeviceStatus { get; internal set; }
        
        /// <summary>
        /// <b>True</b> - Device was added
        /// <b>False</b> - Device was removed
        /// </summary>
        public bool IsAdded { get; internal set; }
        
        public string SerialNumber { get; internal set; }
    }
}