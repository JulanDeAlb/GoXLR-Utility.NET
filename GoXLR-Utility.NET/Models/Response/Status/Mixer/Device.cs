using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer
{
    public class Device
    {
        [JsonPropertyName("button_down")]
        public ButtonDown.ButtonDown ButtonDown { get; set; }
        
        [JsonPropertyName("cough_button")]
        public CoughButton.CoughButton CoughButton { get; set; }
        
        [JsonPropertyName("effects")]
        public Effects.Effects Effects { get; set; } //TODO
        
        [JsonPropertyName("fader_status")]
        public FaderStatus.FaderStatus FaderStatus { get; set; }
        
        //Will not change since it could only happen once Daemon is not running
        [JsonPropertyName("hardware")]
        public Hardware.Hardware Hardware { get; set; }
        
        [JsonPropertyName("levels")]
        public Levels.Levels Levels { get; set; }
        
        [JsonPropertyName("lighting")]
        public Lighting.Lighting Lighting { get; set; } //TODO
        
        [JsonPropertyName("mic_profile_name")]
        public string MicProfileName { get; set; }
        
        [JsonPropertyName("mic_status")]
        public MicStatus.MicStatus MicStatus { get; set; } //New Event Structure TODO InProgress
        
        [JsonPropertyName("profile_name")]
        public string ProfileName { get; set; }
        
        [JsonPropertyName("router")]
        public Router.Router Router { get; set; }
        
        [JsonPropertyName("sampler")]
        public Sampler.Sampler Sampler { get; set; } //TODO
        
        [JsonPropertyName("settings")]
        public Settings.Settings Settings { get; set; }
    }
}