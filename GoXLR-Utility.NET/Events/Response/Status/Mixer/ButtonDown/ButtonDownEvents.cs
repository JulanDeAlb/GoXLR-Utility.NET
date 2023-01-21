using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.ButtonDown;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.ButtonDown
{
    /// <summary>
    /// <seealso cref="ButtonDown"/>
    /// </summary>
    public class ButtonDownEvents
    {
        public event EventHandler<ButtonEventArgs> OnButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnBleepButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnCoughButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectFxButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectHardTuneButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectMegaphoneButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectRobotButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect1ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect2ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect3ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect4ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect5ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnEffectSelect6ButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnFader1MuteButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnFader2MuteButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnFader3MuteButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnFader4MuteButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerClearButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerSelectAButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerSelectBButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerSelectCButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerBottomLeftButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerBottomRightButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerTopLeftButtonDown;
        
        public event EventHandler<BoolDeviceEventArgs> OnSamplerTopRightButtonDown;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.ButtonDown.ButtonDown buttonDown, MemberInfo memInfo)
        {
            var buttonArgs = new ButtonEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            var boolDeviceEventArgs = new BoolDeviceEventArgs()
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    buttonArgs.TypeChanged = ButtonEnum.Bleep;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Bleep;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnBleepButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "Cough":
                    buttonArgs.TypeChanged = ButtonEnum.Cough;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Cough;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnCoughButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectFx":
                    buttonArgs.TypeChanged = ButtonEnum.EffectFx;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectFx;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectFxButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectHardTune":
                    buttonArgs.TypeChanged = ButtonEnum.EffectHardTune;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectHardTune;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectHardTuneButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectMegaphone":
                    buttonArgs.TypeChanged = ButtonEnum.EffectMegaphone;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectMegaphone;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectMegaphoneButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectRobot":
                    buttonArgs.TypeChanged = ButtonEnum.EffectRobot;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectRobot;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectRobotButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect1":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect1;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect1;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect1ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect2":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect2;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect2;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect2ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect3":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect3;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect3;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect3ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect4":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect4;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect4;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect4ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect5":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect5;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect5;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect5ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "EffectSelect6":
                    buttonArgs.TypeChanged = ButtonEnum.EffectSelect6;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.EffectSelect6;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect6ButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "Fader1Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader1Mute;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Fader1Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader1MuteButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "Fader2Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader2Mute;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Fader2Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader2MuteButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "Fader3Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader3Mute;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Fader3Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader3MuteButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "Fader4Mute":
                    buttonArgs.TypeChanged = ButtonEnum.Fader4Mute;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.Fader4Mute;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader4MuteButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerClear":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerClear;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerClear;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerClearButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerSelectA":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectA;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerSelectA;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectAButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerSelectB":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectB;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerSelectB;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectBButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerSelectC":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerSelectC;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerSelectC;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectCButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerTopLeft":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerTopLeft;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerTopLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopLeftButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerTopRight":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerTopRight;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerTopRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopRightButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerBottomLeft":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerBottomLeft;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerBottomLeft;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomLeftButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                case "SamplerBottomRight":
                    buttonArgs.TypeChanged = ButtonEnum.SamplerBottomRight;
                    buttonArgs.Value = boolDeviceEventArgs.Value = buttonDown.SamplerBottomRight;
                    
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomRightButtonDown?.Invoke(this, boolDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ButtonDownEvents");
            }
        }
    }
}