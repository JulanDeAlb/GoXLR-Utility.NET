using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels
{
    public class LevelEventArgs
    {
        /// <summary>
        /// Indicating which type of the Levels has been changed
        /// </summary>
        public LevelEnum LevelEnum { get; set; }
        
        public string SerialNumber { get; set; }
        
        public sbyte Volume { get; set; }
    }
}