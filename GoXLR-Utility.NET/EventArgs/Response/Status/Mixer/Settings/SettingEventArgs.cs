using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings
{
    public class SettingEventArgs : System.EventArgs
    {
        public int MuteHoldDuration { get; set; }
        
        public string SerialNumber { get; set; }

        /// <summary>
        /// Indicating which type of the Setting has been changed
        /// </summary>
        public SettingsEnum SettingsEnum { get; set; }
        
        public bool VcMuteAlsoMuteCm { get; set; }
    }
}