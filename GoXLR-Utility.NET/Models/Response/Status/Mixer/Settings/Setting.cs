using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings
{
    /// <summary>
    /// <seealso cref="SettingEvents"/>
    /// </summary>
    public class Settings
    {
        [JsonPropertyName("display")]
        public GuiDisplay.GuiDisplay Display { get; set; }
        
        [JsonPropertyName("mute_hold_duration")]
        public int MuteHoldDuration { get; set; }
        
        /// <summary>
        /// VoiceChat mute also mutes ChatMic
        /// </summary>
        [JsonPropertyName("vc_mute_also_mute_cm")]
        public bool VcMuteAlsoMuteCm { get; set; }
    }
}