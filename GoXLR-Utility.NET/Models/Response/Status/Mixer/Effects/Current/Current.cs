using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current
{
    public class Current : INotifyPropertyChanged
    {
        private EchoEffect _echo;
        private GenderEffect _gender;
        private HardTuneEffect _hardTune;
        private MegaphoneEffect _megaphone;
        private PitchEffect _pitch;
        private ReverbEffect _reverb;
        private RobotEffect _robot;
        
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