using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels.Volumes
{
    public class VolumeChangedEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which Channel Volume has been changed
        /// </summary>
        public ChannelEnum Channel { get; internal set; }
        
        public int Volume { get; internal set; }
    }
}