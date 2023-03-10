using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.ButtonDown
{
    //Path: mixer/SERIAL-NUMBER/button_down/...
    public class ButtonDown : INotifyPropertyChanged
    {
        private bool _bleep;
        private bool _cough;
        private bool _effectFx;
        private bool _effectHardTune;
        private bool _effectMegaphone;
        private bool _effectRobot;
        private bool _effectSelect1;
        private bool _effectSelect2;
        private bool _effectSelect3;
        private bool _effectSelect4;
        private bool _effectSelect5;
        private bool _effectSelect6;
        private bool _fader1Mute;
        private bool _fader2Mute;
        private bool _fader3Mute;
        private bool _fader4Mute;
        private bool _samplerClear;
        private bool _samplerSelectA;
        private bool _samplerSelectB;
        private bool _samplerSelectC;
        private bool _samplerBottomLeft;
        private bool _samplerBottomRight;
        private bool _samplerTopLeft;
        private bool _samplerTopRight;

        [JsonPropertyName("Bleep")]
        public bool Bleep
        {
            get => _bleep;
            set => SetField(ref _bleep, value);
        }

        [JsonPropertyName("Cough")]
        public bool Cough
        {
            get => _cough;
            set => SetField(ref _cough, value);
        }

        [JsonPropertyName("EffectFx")]
        public bool EffectFx
        {
            get => _effectFx;
            set => SetField(ref _effectFx, value);
        }
        
        [JsonPropertyName("EffectHardTune")]
        public bool EffectHardTune
        {
            get => _effectHardTune;
            set => SetField(ref _effectHardTune, value);
        }
        
        [JsonPropertyName("EffectMegaphone")]
        public bool EffectMegaphone
        {
            get => _effectMegaphone;
            set => SetField(ref _effectMegaphone, value);
        }
        
        [JsonPropertyName("EffectRobot")]
        public bool EffectRobot
        {
            get => _effectRobot;
            set => SetField(ref _effectRobot, value);
        }

        [JsonPropertyName("EffectSelect1")]
        public bool EffectSelect1
        {
            get => _effectSelect1;
            set => SetField(ref _effectSelect1, value);
        }
        
        [JsonPropertyName("EffectSelect2")]
        public bool EffectSelect2
        {
            get => _effectSelect2;
            set => SetField(ref _effectSelect2, value);
        }
        
        [JsonPropertyName("EffectSelect3")]
        public bool EffectSelect3
        {
            get => _effectSelect3;
            set => SetField(ref _effectSelect3, value);
        }
        
        [JsonPropertyName("EffectSelect4")]
        public bool EffectSelect4
        {
            get => _effectSelect4;
            set => SetField(ref _effectSelect4, value);
        }
        
        [JsonPropertyName("EffectSelect5")]
        public bool EffectSelect5
        {
            get => _effectSelect5;
            set => SetField(ref _effectSelect5, value);
        }
        
        [JsonPropertyName("EffectSelect6")]
        public bool EffectSelect6
        {
            get => _effectSelect6;
            set => SetField(ref _effectSelect6, value);
        }
        
        [JsonPropertyName("Fader1Mute")]
        public bool Fader1Mute
        {
            get => _fader1Mute;
            set => SetField(ref _fader1Mute, value);
        }
        
        [JsonPropertyName("Fader2Mute")]
        public bool Fader2Mute
        {
            get => _fader2Mute;
            set => SetField(ref _fader2Mute, value);
        }
        
        [JsonPropertyName("Fader3Mute")]
        public bool Fader3Mute
        {
            get => _fader3Mute;
            set => SetField(ref _fader3Mute, value);
        }
        
        [JsonPropertyName("Fader4Mute")]
        public bool Fader4Mute
        {
            get => _fader4Mute;
            set => SetField(ref _fader4Mute, value);
        }

        [JsonPropertyName("SamplerClear")]
        public bool SamplerClear
        {
            get => _samplerClear;
            set => SetField(ref _samplerClear, value);
        }

        [JsonPropertyName("SamplerSelectA")]
        public bool SamplerSelectA
        {
            get => _samplerSelectA;
            set => SetField(ref _samplerSelectA, value);
        }
        
        [JsonPropertyName("SamplerSelectB")]
        public bool SamplerSelectB
        {
            get => _samplerSelectB;
            set => SetField(ref _samplerSelectB, value);
        }
        
        [JsonPropertyName("SamplerSelectC")]
        public bool SamplerSelectC
        {
            get => _samplerSelectC;
            set => SetField(ref _samplerSelectC, value);
        }
        
        [JsonPropertyName("SamplerBottomLeft")]
        public bool SamplerBottomLeft
        {
            get => _samplerBottomLeft;
            set => SetField(ref _samplerBottomLeft, value);
        }
        
        [JsonPropertyName("SamplerBottomRight")]
        public bool SamplerBottomRight
        {
            get => _samplerBottomRight;
            set => SetField(ref _samplerBottomRight, value);
        }
        
        [JsonPropertyName("SamplerTopLeft")]
        public bool SamplerTopLeft
        {
            get => _samplerTopLeft;
            set => SetField(ref _samplerTopLeft, value);
        }
        
        [JsonPropertyName("SamplerTopRight")]
        public bool SamplerTopRight
        {
            get => _samplerTopRight;
            set => SetField(ref _samplerTopRight, value);
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