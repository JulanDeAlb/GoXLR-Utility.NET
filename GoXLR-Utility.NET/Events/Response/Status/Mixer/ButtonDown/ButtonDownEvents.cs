using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.ButtonDown;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.ButtonDown
{
    /// <summary>
    /// <seealso cref="ButtonDown"/>
    /// </summary>
    public class ButtonDownEvents
    {
        public event EventHandler<ButtonEventArgs> OnButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnBleepButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnCoughButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectFxButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectHardTuneButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectMegaphoneButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectRobotButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect1ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect2ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect3ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect4ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect5ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnEffectSelect6ButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnFader1MuteButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnFader2MuteButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnFader3MuteButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnFader4MuteButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerClearButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerSelectAButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerSelectBButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerSelectCButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerBottomLeftButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerBottomRightButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerTopLeftButtonDown;
        
        public event EventHandler<BoolButtonEventArgs> OnSamplerTopRightButtonDown;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.ButtonDown.ButtonDown buttonDown, MemberInfo memInfo)
        {
            var buttonArgs = new ButtonEventArgs
            {
                SerialNumber = serialNumber,
            };
            var boolButtonEventArgs = new BoolButtonEventArgs()
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    buttonArgs.TypeChanged = ButtonEnum.Bleep;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Bleep;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnBleepButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "Cough":
                    buttonArgs.TypeChanged = ButtonEnum.Cough;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Cough;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnCoughButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectFx":
                    buttonArgs.TypeChanged = ButtonEnum.EffectFx;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectFx;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectFxButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectHardTune":
                    buttonArgs.TypeChanged = ButtonEnum.EffectHardTune;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectHardTune;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectHardTuneButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectMegaphone":
                    buttonArgs.TypeChanged = ButtonEnum.EffectMegaphone;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectMegaphone;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectMegaphoneButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectRobot":
                    buttonArgs.TypeChanged = ButtonEnum.EffectRobot;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectRobot;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectRobotButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect1":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect1;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect1;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect1ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect2":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect2;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect2;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect2ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect3":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect3;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect3;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect3ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect4":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect4;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect4;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect4ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect5":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect5;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect5;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect5ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "EffectSelect6":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect6;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.EffectSelect6;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect6ButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "Fader1Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader1Mute;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Fader1Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader1MuteButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "Fader2Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader2Mute;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Fader2Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader2MuteButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "Fader3Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader3Mute;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Fader3Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader3MuteButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "Fader4Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader4Mute;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.Fader4Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader4MuteButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerClear":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerClear;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerClear;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerClearButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerSelectA":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectA;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerSelectA;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectAButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerSelectB":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectB;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerSelectB;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectBButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerSelectC":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectC;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerSelectC;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectCButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerTopLeft":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerTopLeft;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerTopLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopLeftButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerTopRight":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerTopRight;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerTopRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopRightButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerBottomLeft":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerBottomLeft;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerBottomLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomLeftButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                case "SamplerBottomRight":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerBottomRight;
                    buttonArgs.Value = boolButtonEventArgs.Value = buttonDown.SamplerBottomRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomRightButtonDown?.Invoke(this, boolButtonEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ButtonDownEvents");
            }
        }
    }
}