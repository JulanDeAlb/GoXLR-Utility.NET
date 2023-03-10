using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    //Path: mixer/SERIAL-NUMBER/effects/preset_names/current/echo/...
    public class EchoEffect : INotifyPropertyChanged
    {
        private int _amount;
        private int _delayLeft;
        private int _delayRight;
        private int _feedback;
        private int _feedbackLeft;
        private int _feedbackRight;
        private int _feedbackXfbRtL;
        private int _feedbackXfbLtR;
        private EchoStyle _style;
        private int _tempo;
        
        [JsonPropertyName("amount")]
        public int Amount
        {
            get => _amount;
            set => SetField(ref _amount, value);
        }
        
        [JsonPropertyName("delay_left")]
        public int DelayLeft
        {
            get => _delayLeft;
            set => SetField(ref _delayLeft, value);
        }
        
        [JsonPropertyName("delay_right")]
        public int DelayRight
        {
            get => _delayRight;
            set => SetField(ref _delayRight, value);
        }
        
        [JsonPropertyName("feedback")]
        public int Feedback
        {
            get => _feedback;
            set => SetField(ref _feedback, value);
        }
        
        [JsonPropertyName("feedback_left")]
        public int FeedbackLeft
        {
            get => _feedbackLeft;
            set => SetField(ref _feedbackLeft, value);
        }
        
        [JsonPropertyName("feedback_right")]
        public int FeedbackRight
        {
            get => _feedbackRight;
            set => SetField(ref _feedbackRight, value);
        }
        
        [JsonPropertyName("feedback_xfb_r_to_l")]
        public int FeedbackXfbRtL
        {
            get => _feedbackXfbRtL;
            set => SetField(ref _feedbackXfbRtL, value);
        }
        
        [JsonPropertyName("feedback_xfb_l_to_r")]
        public int FeedbackXfbLtR
        {
            get => _feedbackXfbLtR;
            set => SetField(ref _feedbackXfbLtR, value);
        }
        
        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EchoStyle Style
        {
            get => _style;
            set => SetField(ref _style, value);
        }
        
        [JsonPropertyName("tempo")]
        public int Tempo
        {
            get => _tempo;
            set => SetField(ref _tempo, value);
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