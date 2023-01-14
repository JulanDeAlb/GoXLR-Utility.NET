using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Config;

namespace GoXLR_Utility.NET.Models.Response.Status.Config
{
    //Path: config/...
    
    /// <summary>
    /// <seealso cref="ConfigEvents"/>
    /// </summary>
    public class Config
    {
        [JsonPropertyName("daemon_version")]
        public string DaemonVersion { get; set; }
        
        [JsonPropertyName("autostart_enabled")]
        public bool AutostartEnabled { get; set; }
        
        [JsonPropertyName("show_tray_icon")]
        public bool ShowTrayIcon { get; set; }
    }
}