using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.CoughButton
{
    //Path: mixer/SERIAL-NUMBER/cough_button/...
    public class CoughButton : INotifyPropertyChanged
    {
        private bool _isToggle;
        private MuteFunction _muteFunction;
        private MuteState _muteState;
        
        [JsonPropertyName("is_toggle")]
        public bool IsToggle
        {
            get => _isToggle;
            internal set => SetField(ref _isToggle, value);
        }
        
        [JsonPropertyName("mute_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteFunction MuteFunction
        {
            get => _muteFunction;
            internal set => SetField(ref _muteFunction, value);
        }
        
        [JsonPropertyName("state")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteState MuteState
        {
            get => _muteState;
            internal set => SetField(ref _muteState, value);
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