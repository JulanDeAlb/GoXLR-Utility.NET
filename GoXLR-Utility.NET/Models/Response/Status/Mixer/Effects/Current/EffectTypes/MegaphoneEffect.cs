using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes
{
    //Path: mixer/SERIAL-NUMBER/effects/preset_names/current/megaphone/...
    public class MegaphoneEffect : INotifyPropertyChanged
    {
        private int _amount;
        private bool _isEnabled;
        private int _postGain;
        private MegaphoneStyle _style;
        
        [JsonPropertyName("amount")]
        public int Amount
        {
            get => _amount;
            set => SetField(ref _amount, value);
        }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetField(ref _isEnabled, value);
        }
        
        [JsonPropertyName("post_gain")]
        public int PostGain
        {
            get => _postGain;
            set => SetField(ref _postGain, value);
        }

        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MegaphoneStyle Style
        {
            get => _style;
            set => SetField(ref _style, value);
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