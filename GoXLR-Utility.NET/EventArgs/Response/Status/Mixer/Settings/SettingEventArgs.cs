using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings
{
    public class SettingEventArgs : System.EventArgs
    {
        public bool BoolValue { get; internal set; }
        
        public int IntValue { get; internal set; }
        
        public string SerialNumber { get; internal set; }

        /// <summary>
        /// Indicating which type of the Setting has been changed
        /// </summary>
        public SettingsEnum TypeChanged { get; internal set; }
    }
}