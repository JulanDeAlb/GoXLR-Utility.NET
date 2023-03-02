using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current
{
    public class Current : INotifyPropertyChanged
    {
        private EchoEffect _echo = null!;
        private GenderEffect _gender = null!;
        private HardTuneEffect _hardTune = null!;
        private MegaphoneEffect _megaphone = null!;
        private PitchEffect _pitch = null!;
        private ReverbEffect _reverb = null!;
        private RobotEffect _robot = null!;
        
        [JsonPropertyName("echo")]
        public EchoEffect Echo
        {
            get => _echo;
            set => SetField(ref _echo, value);
        }
        
        [JsonPropertyName("gender")]
        public GenderEffect Gender
        {
            get => _gender;
            set => SetField(ref _gender, value);
        }
        
        [JsonPropertyName("hard_tune")]
        public HardTuneEffect HardTune
        {
            get => _hardTune;
            set => SetField(ref _hardTune, value);
        }
        
        [JsonPropertyName("megaphone")]
        public MegaphoneEffect Megaphone
        {
            get => _megaphone;
            set => SetField(ref _megaphone, value);
        }
        
        [JsonPropertyName("pitch")]
        public PitchEffect Pitch
        {
            get => _pitch;
            set => SetField(ref _pitch, value);
        }
        
        [JsonPropertyName("reverb")]
        public ReverbEffect Reverb
        {
            get => _reverb;
            set => SetField(ref _reverb, value);
        }
        
        [JsonPropertyName("robot")]
        public RobotEffect Robot
        {
            get => _robot;
            set => SetField(ref _robot, value);
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