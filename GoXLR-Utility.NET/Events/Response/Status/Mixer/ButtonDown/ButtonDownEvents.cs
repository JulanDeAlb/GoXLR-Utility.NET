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
        /// <summary>
        /// Triggers when any Button is pressed.
        /// Includes a <see cref="ButtonEnum"/>.
        /// </summary>
        public event EventHandler<ButtonEventArgs> OnButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnBleepButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnCoughButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectFxButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectHardTuneButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectMegaphoneButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectRobotButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect1ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect2ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect3ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect4ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect5ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnEffectSelect6ButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnFader1MuteButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnFader2MuteButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnFader3MuteButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnFader4MuteButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerSelectAButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerSelectBButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerSelectCButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerBottomLeftButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerBottomRightButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerTopLeftButtonDown;
        
        /// <summary>
        /// Triggers only when this specific Button is pressed.
        ///</summary>
        public event EventHandler<SpecificButtonEventArgs> OnSamplerTopRightButtonDown;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.ButtonDown.ButtonDown myClass, MemberInfo memInfo)
        {
            var buttonArgs = new ButtonEventArgs
            {
                SerialNumber = serialNumber,
            };
            var specButtonArgs = new SpecificButtonEventArgs()
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    buttonArgs.Button = ButtonEnum.Bleep;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Bleep;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnBleepButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Cough":
                    buttonArgs.Button = ButtonEnum.Cough;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Cough;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnCoughButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectFx":
                    buttonArgs.Button = ButtonEnum.EffectFx;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectFx;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectFxButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectHardTune":
                    buttonArgs.Button = ButtonEnum.EffectHardTune;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectHardTune;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectHardTuneButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectMegaphone":
                    buttonArgs.Button = ButtonEnum.EffectMegaphone;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectMegaphone;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectMegaphoneButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectRobot":
                    buttonArgs.Button = ButtonEnum.EffectRobot;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectRobot;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectRobotButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect1":
                    buttonArgs.Button = ButtonEnum.EffectSelect1;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect1;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect1ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect2":
                    buttonArgs.Button = ButtonEnum.EffectSelect2;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect2;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect2ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect3":
                    buttonArgs.Button = ButtonEnum.EffectSelect3;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect3;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect3ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect4":
                    buttonArgs.Button = ButtonEnum.EffectSelect4;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect4;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect4ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect5":
                    buttonArgs.Button = ButtonEnum.EffectSelect5;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect5;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect5ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "EffectSelect6":
                    buttonArgs.Button = ButtonEnum.EffectSelect6;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.EffectSelect6;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnEffectSelect6ButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader1Mute":
                    buttonArgs.Button = ButtonEnum.Fader1Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Fader1Mute;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader1MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader2Mute":
                    buttonArgs.Button = ButtonEnum.Fader2Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Fader2Mute;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader2MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader3Mute":
                    buttonArgs.Button = ButtonEnum.Fader3Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Fader3Mute;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader3MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "Fader4Mute":
                    buttonArgs.Button = ButtonEnum.Fader4Mute;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.Fader4Mute;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnFader4MuteButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectA":
                    buttonArgs.Button = ButtonEnum.SamplerSelectA;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerSelectA;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectAButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectB":
                    buttonArgs.Button = ButtonEnum.SamplerSelectB;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerSelectB;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectBButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerSelectC":
                    buttonArgs.Button = ButtonEnum.SamplerSelectC;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerSelectC;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerSelectCButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerTopLeft":
                    buttonArgs.Button = ButtonEnum.SamplerTopLeft;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerTopLeft;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopLeftButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerTopRight":
                    buttonArgs.Button = ButtonEnum.SamplerTopRight;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerTopRight;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerTopRightButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerBottomLeft":
                    buttonArgs.Button = ButtonEnum.SamplerBottomLeft;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerBottomLeft;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomLeftButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                case "SamplerBottomRight":
                    buttonArgs.Button = ButtonEnum.SamplerBottomRight;
                    buttonArgs.IsButtonDown = specButtonArgs.IsButtonDown = myClass.SamplerBottomRight;
                    OnButtonDown?.Invoke(this, buttonArgs);
                    OnSamplerBottomRightButtonDown?.Invoke(this, specButtonArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ButtonDownEvents");
            }
        }
    }
}