using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer
{
    public class Device : INotifyPropertyChanged
    {
        private ButtonDown.ButtonDown _buttonDown = null!;
        private CoughButton.CoughButton _coughButton = null!;
        private Effects.Effects _effects = null!;
        private FaderStatus.FaderStatus _faderStatus = null!;
        private Hardware.Hardware _hardware = null!;
        private Levels.Levels _levels = null!;
        private Lighting.Lighting _lighting = null!;
        private string _micProfileName = null!;
        private MicStatus.MicStatus _micStatus = null!;
        private string _profileName = null!;
        private Router.Router _router = null!;
        private Sampler.Sampler _sampler = null!;
        private Settings.Settings _settings = null!;

        [JsonPropertyName("button_down")]
        public ButtonDown.ButtonDown ButtonDown
        {
            get => _buttonDown;
            set => SetField(ref _buttonDown, value);
        }
        
        [JsonPropertyName("cough_button")]
        public CoughButton.CoughButton CoughButton
        {
            get => _coughButton;
            set => SetField(ref _coughButton, value);
        }
        
        [JsonPropertyName("effects")]
        public Effects.Effects Effects
        {
            get => _effects;
            set => SetField(ref _effects, value);
        }
        
        [JsonPropertyName("fader_status")]
        public FaderStatus.FaderStatus FaderStatus
        {
            get => _faderStatus;
            set => SetField(ref _faderStatus, value);
        }
        
        //Will not change since it could only happen once the Daemon is not running
        [JsonPropertyName("hardware")]
        public Hardware.Hardware Hardware
        {
            get => _hardware;
            set => SetField(ref _hardware, value);
        }
        
        [JsonPropertyName("levels")]
        public Levels.Levels Levels
        {
            get => _levels;
            set => SetField(ref _levels, value);
        }
        
        [JsonPropertyName("lighting")]
        public Lighting.Lighting Lighting
        {
            get => _lighting;
            set => SetField(ref _lighting, value);
        }
        
        [JsonPropertyName("mic_profile_name")]
        public string MicProfileName
        {
            get => _micProfileName;
            set => SetField(ref _micProfileName, value);
        }
        
        [JsonPropertyName("mic_status")]
        public MicStatus.MicStatus MicStatus
        {
            get => _micStatus;
            set => SetField(ref _micStatus, value);
        }
        
        [JsonPropertyName("profile_name")]
        public string ProfileName
        {
            get => _profileName;
            set => SetField(ref _profileName, value);
        }
        
        [JsonPropertyName("router")]
        public Router.Router Router
        {
            get => _router;
            set => SetField(ref _router, value);
        }
        
        [JsonPropertyName("sampler")]
        public Sampler.Sampler Sampler
        {
            get => _sampler;
            set => SetField(ref _sampler, value);
        }
        
        [JsonPropertyName("settings")]
        public Settings.Settings Settings
        {
            get => _settings;
            set => SetField(ref _settings, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}