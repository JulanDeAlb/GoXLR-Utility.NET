using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus
{
    public class FaderStatus : INotifyPropertyChanged
    {
        private FaderBase _faderA;
        private FaderBase _faderB;
        private FaderBase _faderC;
        private FaderBase _faderD;
        
        [JsonPropertyName("A")]
        public FaderBase FaderA
        {
            get => _faderA;
            set => SetField(ref _faderA, value);
        }
        
        [JsonPropertyName("B")]
        public FaderBase FaderB
        {
            get => _faderB;
            set => SetField(ref _faderB, value);
        }
        
        [JsonPropertyName("C")]
        public FaderBase FaderC
        {
            get => _faderC;
            set => SetField(ref _faderC, value);
        }
        
        [JsonPropertyName("D")]
        public FaderBase FaderD
        {
            get => _faderD;
            set => SetField(ref _faderD, value);
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
    
    public class FaderBase : INotifyPropertyChanged
    {
        private ChannelName _channel;
        private MuteFunction _muteType;
        private MuteState _muteState;
        private Scribble.FaderScribble _scribble;
        
        [JsonPropertyName("channel")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ChannelName Channel
        {
            get => _channel;
            set => SetField(ref _channel, value);
        }
        
        [JsonPropertyName("mute_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MuteFunction MuteType
        {
            get => _muteType;
            set => SetField(ref _muteType, value);
        }
        
        [JsonPropertyName("mute_state")]
        public MuteState MuteState
        {
            get => _muteState;
            set => SetField(ref _muteState, value);
        }
        
        [JsonPropertyName("scribble")]
        public Scribble.FaderScribble Scribble
        {
            get => _scribble;
            set => SetField(ref _scribble, value);
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