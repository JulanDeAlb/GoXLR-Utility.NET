using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels.Submix;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Submix.SubmixOutputs
{
    //Path: mixer/SERIAL-NUMBER/levels/submix/outputs
    public class SubmixOutputs : INotifyPropertyChanged
    {
        private SubmixOutput _broadcastMix;
        private SubmixOutput _chatMic;
        private SubmixOutput _headphone;
        private SubmixOutput _lineOut;
        private SubmixOutput _sampler;
        
        [JsonPropertyName("BroadcastMix")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubmixOutput BroadcastMix
        {
            get => _broadcastMix;
            set => SetField(ref _broadcastMix, value);
        }
        
        [JsonPropertyName("ChatMic")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubmixOutput ChatMic
        {
            get => _chatMic;
            set => SetField(ref _chatMic, value);
        }
        
        [JsonPropertyName("Headphone")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubmixOutput Headphone
        {
            get => _headphone;
            set => SetField(ref _headphone, value);
        }
        
        [JsonPropertyName("LineOut")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubmixOutput LineOut
        {
            get => _lineOut;
            set => SetField(ref _lineOut, value);
        }
        
        [JsonPropertyName("Sampler")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubmixOutput Sampler
        {
            get => _sampler;
            set => SetField(ref _sampler, value);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}