using GoXLR_Utility.NET.Enums.Response.Status.Config;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Config
{
    public class ConfigEventArgs : System.EventArgs
    {
        public bool AutostartEnabled { get; internal set; }
        
        public string DaemonVersion { get; internal set; }
        
        public bool ShowTrayIcon { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public ConfigEnum TypeChanged { get; internal set; }
    }
}