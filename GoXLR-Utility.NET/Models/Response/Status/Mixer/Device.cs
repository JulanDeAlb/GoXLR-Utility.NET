using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer
{
    public class Device : INotifyPropertyChanged
    {
        private ButtonDown.ButtonDown _buttonDown;
        private CoughButton.CoughButton _coughButton;
        private Effects.Effects _effects;
        private FaderStatus.FaderStatus _faderStatus;
        private Hardware.Hardware _hardware;
        private Levels.Levels _levels;
        private Lighting.Lighting _lighting;
        private string _micProfileName;
        private MicStatus.MicStatus _micStatus;
        private string _profileName;
        private Router.Router _router;
        private Sampler.Sampler _sampler;
        private Settings.Settings _settings;

        [JsonPropertyName("button_down")]
        public ButtonDown.ButtonDown ButtonDown
        {
            get => _buttonDown;
            internal set => SetField(ref _buttonDown, value);
        }
        
        [JsonPropertyName("cough_button")]
        public CoughButton.CoughButton CoughButton
        {
            get => _coughButton;
            internal set => SetField(ref _coughButton, value);
        }
        
        [JsonPropertyName("effects")]
        public Effects.Effects Effects
        {
            get => _effects;
            internal set => SetField(ref _effects, value);
        }
        
        [JsonPropertyName("fader_status")]
        public FaderStatus.FaderStatus FaderStatus
        {
            get => _faderStatus;
            internal set => SetField(ref _faderStatus, value);
        }
        
        //Will not change since it could only happen once the Daemon is not running
        [JsonPropertyName("hardware")]
        public Hardware.Hardware Hardware
        {
            get => _hardware;
            internal set => SetField(ref _hardware, value);
        }
        
        [JsonPropertyName("levels")]
        public Levels.Levels Levels
        {
            get => _levels;
            internal set => SetField(ref _levels, value);
        }
        
        [JsonPropertyName("lighting")]
        public Lighting.Lighting Lighting
        {
            get => _lighting;
            internal set => SetField(ref _lighting, value);
        }
        
        [JsonPropertyName("mic_profile_name")]
        public string MicProfileName
        {
            get => _micProfileName;
            internal set => SetField(ref _micProfileName, value);
        }
        
        [JsonPropertyName("mic_status")]
        public MicStatus.MicStatus MicStatus
        {
            get => _micStatus;
            internal set => SetField(ref _micStatus, value);
        }
        
        [JsonPropertyName("profile_name")]
        public string ProfileName
        {
            get => _profileName;
            internal set => SetField(ref _profileName, value);
        }
        
        [JsonPropertyName("router")]
        public Router.Router Router
        {
            get => _router;
            internal set => SetField(ref _router, value);
        }
        
        [JsonPropertyName("sampler")]
        public Sampler.Sampler Sampler
        {
            get => _sampler;
            internal set => SetField(ref _sampler, value);
        }
        
        [JsonPropertyName("settings")]
        public Settings.Settings Settings
        {
            get => _settings;
            internal set => SetField(ref _settings, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}