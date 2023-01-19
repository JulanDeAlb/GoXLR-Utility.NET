using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels
{
    public class LevelEventArgs
    {
        public string SerialNumber { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Levels has been changed
        /// </summary>
        public LevelEnum TypeChanged { get; internal set; }
        
        public sbyte Volume { get; internal set; }
    }
}