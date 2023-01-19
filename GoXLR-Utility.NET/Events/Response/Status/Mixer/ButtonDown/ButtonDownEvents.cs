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
            var specButtonArgs = new BoolButtonEventArgs()
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    buttonArgs.Button = ButtonEnum.Bleep;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Bleep;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnBleepButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Cough":
                    buttonArgs.Button = ButtonEnum.Cough;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Cough;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnCoughButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectFx":
                    buttonArgs.Button = ButtonEnum.EffectFx;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectFx;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectFxButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectHardTune":
                    buttonArgs.Button = ButtonEnum.EffectHardTune;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectHardTune;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectHardTuneButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectMegaphone":
                    buttonArgs.Button = ButtonEnum.EffectMegaphone;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectMegaphone;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectMegaphoneButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectRobot":
                    buttonArgs.Button = ButtonEnum.EffectRobot;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectRobot;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectRobotButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect1":
                    buttonArgs.Button = ButtonEnum.EffectSelect1;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect1;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect1ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect2":
                    buttonArgs.Button = ButtonEnum.EffectSelect2;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect2;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect2ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect3":
                    buttonArgs.Button = ButtonEnum.EffectSelect3;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect3;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect3ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect4":
                    buttonArgs.Button = ButtonEnum.EffectSelect4;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect4;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect4ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect5":
                    buttonArgs.Button = ButtonEnum.EffectSelect5;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect5;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect5ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect6":
                    buttonArgs.Button = ButtonEnum.EffectSelect6;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.EffectSelect6;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect6ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader1Mute":
                    buttonArgs.Button = ButtonEnum.Fader1Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Fader1Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader1MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader2Mute":
                    buttonArgs.Button = ButtonEnum.Fader2Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Fader2Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader2MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader3Mute":
                    buttonArgs.Button = ButtonEnum.Fader3Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Fader3Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader3MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader4Mute":
                    buttonArgs.Button = ButtonEnum.Fader4Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.Fader4Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader4MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectA":
                    buttonArgs.Button = ButtonEnum.SamplerSelectA;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerSelectA;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectAButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectB":
                    buttonArgs.Button = ButtonEnum.SamplerSelectB;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerSelectB;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectBButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectC":
                    buttonArgs.Button = ButtonEnum.SamplerSelectC;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerSelectC;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectCButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerTopLeft":
                    buttonArgs.Button = ButtonEnum.SamplerTopLeft;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerTopLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopLeftButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerTopRight":
                    buttonArgs.Button = ButtonEnum.SamplerTopRight;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerTopRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopRightButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerBottomLeft":
                    buttonArgs.Button = ButtonEnum.SamplerBottomLeft;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerBottomLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomLeftButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerBottomRight":
                    buttonArgs.Button = ButtonEnum.SamplerBottomRight;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = buttonDown.SamplerBottomRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomRightButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ButtonDownEvents");
            }
        }
    }
}