using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons
{
    public class ButtonLight : INotifyPropertyChanged
    {
        private ButtonLightBase _bleep;
        private ButtonLightBase _cough;
        private ButtonLightBase _effectFx;
        private ButtonLightBase _effectHardTune;
        private ButtonLightBase _effectMegaphone;
        private ButtonLightBase _effectRobot;
        private ButtonLightBase _effectSelect1;
        private ButtonLightBase _effectSelect2;
        private ButtonLightBase _effectSelect3;
        private ButtonLightBase _effectSelect4;
        private ButtonLightBase _effectSelect5;
        private ButtonLightBase _effectSelect6;
        private ButtonLightBase _faderAMute;
        private ButtonLightBase _faderBMute;
        private ButtonLightBase _faderCMute;
        private ButtonLightBase _faderDMute;
        
        [JsonPropertyName("Bleep")]
        public ButtonLightBase Bleep
        {
            get => _bleep;
            set => SetField(ref _bleep, value);
        }
        
        [JsonPropertyName("Cough")]
        public ButtonLightBase Cough
        {
            get => _cough;
            set => SetField(ref _cough, value);
        }
        
        [JsonPropertyName("EffectFx")]
        public ButtonLightBase EffectFx
        {
            get => _effectFx;
            set => SetField(ref _effectFx, value);
        }
        
        [JsonPropertyName("EffectHardTune")]
        public ButtonLightBase EffectHardTune
        {
            get => _effectHardTune;
            set => SetField(ref _effectHardTune, value);
        }
        
        [JsonPropertyName("EffectMegaphone")]
        public ButtonLightBase EffectMegaphone
        {
            get => _effectMegaphone;
            set => SetField(ref _effectMegaphone, value);
        }
        
        [JsonPropertyName("EffectRobot")]
        public ButtonLightBase EffectRobot
        {
            get => _effectRobot;
            set => SetField(ref _effectRobot, value);
        }
        
        [JsonPropertyName("EffectSelect1")]
        public ButtonLightBase EffectSelect1
        {
            get => _effectSelect1;
            set => SetField(ref _effectSelect1, value);
        }
        
        [JsonPropertyName("EffectSelect2")]
        public ButtonLightBase EffectSelect2
        {
            get => _effectSelect2;
            set => SetField(ref _effectSelect2, value);
        }
        
        [JsonPropertyName("EffectSelect3")]
        public ButtonLightBase EffectSelect3
        {
            get => _effectSelect3;
            set => SetField(ref _effectSelect3, value);
        }
        
        [JsonPropertyName("EffectSelect4")]
        public ButtonLightBase EffectSelect4
        {
            get => _effectSelect4;
            set => SetField(ref _effectSelect4, value);
        }
        
        [JsonPropertyName("EffectSelect5")]
        public ButtonLightBase EffectSelect5
        {
            get => _effectSelect5;
            set => SetField(ref _effectSelect5, value);
        }
        
        [JsonPropertyName("EffectSelect6")]
        public ButtonLightBase EffectSelect6
        {
            get => _effectSelect6;
            set => SetField(ref _effectSelect6, value);
        }

        [JsonPropertyName("Fader1Mute")]
        public ButtonLightBase FaderAMute
        {
            get => _faderAMute;
            set => SetField(ref _faderAMute, value);
        }
        
        [JsonPropertyName("Fader2Mute")]
        public ButtonLightBase FaderBMute
        {
            get => _faderBMute;
            set => SetField(ref _faderBMute, value);
        }
        
        [JsonPropertyName("Fader3Mute")]
        public ButtonLightBase FaderCMute
        {
            get => _faderCMute;
            set => SetField(ref _faderCMute, value);
        }
        
        [JsonPropertyName("Fader4Mute")]
        public ButtonLightBase FaderDMute
        {
            get => _faderDMute;
            set => SetField(ref _faderDMute, value);
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
    
    public class ButtonLightBase : INotifyPropertyChanged
    {
        private TwoColour _colour;
        private string _offStyle;
        
        [JsonPropertyName("colours")]
        public TwoColour Colour
        {
            get => _colour;
            set => SetField(ref _colour, value);
        }
        
        [JsonPropertyName("off_style")]
        public string OffStyle
        {
            get => _offStyle;
            set => SetField(ref _offStyle, value);
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