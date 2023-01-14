using GoXLR_Utility.NET.Enums.Response.Status.Config;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Config
{
    public class ConfigEventArgs : System.EventArgs
    {
        public bool AutostartEnabled { get; set; }
        
        /// <summary>
        /// Indicating which type of the Config has been changed
        /// </summary>
        public ConfigEnum ConfigEnum { get; set; }
        
        public string DaemonVersion { get; set; }
        
        public bool ShowTrayIcon { get; set; }
    }
}