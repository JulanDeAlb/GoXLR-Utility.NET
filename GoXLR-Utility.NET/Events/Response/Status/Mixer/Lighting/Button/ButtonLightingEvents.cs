using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Buttons;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting.Button
{
    public class ButtonLightingEvents
    {
        public ButtonLightingBaseEvents Bleep = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents Cough = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectFx = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectHardTune = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectMegaphone = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectRobot = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect1 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect2 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect3 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect4 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect5 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents EffectSelect6 = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents Fader1Mute = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents Fader2Mute = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents Fader3Mute = new ButtonLightingBaseEvents();
        public ButtonLightingBaseEvents Fader4Mute = new ButtonLightingBaseEvents();
        
        public event EventHandler<ButtonLightingBaseEventArgs> OnBleepChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnCoughChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectFxChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectHardTuneChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectMegaphoneChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectRobotChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect1Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect2Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect3Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect4Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect5Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnEffectSelect6Changed;
        public event EventHandler<ButtonLightingBaseEventArgs> OnFader1MuteChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnFader2MuteChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnFader3MuteChanged;
        public event EventHandler<ButtonLightingBaseEventArgs> OnFader4MuteChanged;

        protected internal void HandleEvents(string serialNumber, ButtonLightBase lightBase, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<ButtonLightingEventArgs> buttonChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Button = new ButtonLightingEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (lightBase)
            {
                case Bleep bleep:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Bleep;
                    Bleep.HandleEvents(serialNumber, bleep, memInfo, lightningChanged, buttonChanged, OnBleepChanged, lightingEventArgs);
                    break;
                
                case Cough cough:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Cough;
                    Cough.HandleEvents(serialNumber, cough, memInfo, lightningChanged, buttonChanged, OnCoughChanged, lightingEventArgs);
                    break;
                
                case EffectFx effectFx:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectFx;
                    EffectFx.HandleEvents(serialNumber, effectFx, memInfo, lightningChanged, buttonChanged, OnEffectFxChanged, lightingEventArgs);
                    break;
                
                case EffectHardTune effectHardTune:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectHardTune;
                    EffectHardTune.HandleEvents(serialNumber, effectHardTune, memInfo, lightningChanged, buttonChanged, OnEffectHardTuneChanged, lightingEventArgs);
                    break;
                
                case EffectMegaphone effectMegaphone:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectMegaphone;
                    EffectMegaphone.HandleEvents(serialNumber, effectMegaphone, memInfo, lightningChanged, buttonChanged, OnEffectMegaphoneChanged, lightingEventArgs);
                    break;
                
                case EffectRobot effectRobot:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectRobot;
                    EffectRobot.HandleEvents(serialNumber, effectRobot, memInfo, lightningChanged, buttonChanged, OnEffectRobotChanged, lightingEventArgs);
                    break;
                
                case EffectSelect1 effectSelect1:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect1;
                    EffectSelect1.HandleEvents(serialNumber, effectSelect1, memInfo, lightningChanged, buttonChanged, OnEffectSelect1Changed, lightingEventArgs);
                    break;
                
                case EffectSelect2 effectSelect2:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect2;
                    EffectSelect2.HandleEvents(serialNumber, effectSelect2, memInfo, lightningChanged, buttonChanged, OnEffectSelect2Changed, lightingEventArgs);
                    break;
                
                case EffectSelect3 effectSelect3:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect3;
                    EffectSelect3.HandleEvents(serialNumber, effectSelect3, memInfo, lightningChanged, buttonChanged, OnEffectSelect3Changed, lightingEventArgs);
                    break;
                
                case EffectSelect4 effectSelect4:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect4;
                    EffectSelect4.HandleEvents(serialNumber, effectSelect4, memInfo, lightningChanged, buttonChanged, OnEffectSelect4Changed, lightingEventArgs);
                    break;
                
                case EffectSelect5 effectSelect5:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect5;
                    EffectSelect5.HandleEvents(serialNumber, effectSelect5, memInfo, lightningChanged, buttonChanged, OnEffectSelect5Changed, lightingEventArgs);
                    break;
                
                case EffectSelect6 effectSelect6:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.EffectSelect6;
                    EffectSelect6.HandleEvents(serialNumber, effectSelect6, memInfo, lightningChanged, buttonChanged, OnEffectSelect6Changed, lightingEventArgs);
                    break;
                
                case FaderAMute fader1Mute:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Fader1Mute;
                    Fader1Mute.HandleEvents(serialNumber, fader1Mute, memInfo, lightningChanged, buttonChanged, OnFader1MuteChanged, lightingEventArgs);
                    break;
                
                case FaderBMute fader2Mute:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Fader2Mute;
                    Fader2Mute.HandleEvents(serialNumber, fader2Mute, memInfo, lightningChanged, buttonChanged, OnFader2MuteChanged, lightingEventArgs);
                    break;
                
                case FaderCMute fader3Mute:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Fader3Mute;
                    Fader3Mute.HandleEvents(serialNumber, fader3Mute, memInfo, lightningChanged, buttonChanged, OnFader3MuteChanged, lightingEventArgs);
                    break;
                
                case FaderDMute fader4Mute:
                    lightingEventArgs.Button.TypeChanged = ButtonLightEnum.Fader4Mute;
                    Fader4Mute.HandleEvents(serialNumber, fader4Mute, memInfo, lightningChanged, buttonChanged, OnFader4MuteChanged, lightingEventArgs);
                    break;
                
                default:
                    var type = lightBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in ButtonLightingEvents: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}