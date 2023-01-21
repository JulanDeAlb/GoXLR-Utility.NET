using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Echo
{
    public class EchoEffectEvents
    {
        public event EventHandler<IntDeviceEventArgs> OnAmountChanged;
        public event EventHandler<IntDeviceEventArgs> OnDelayLeftChanged;
        public event EventHandler<IntDeviceEventArgs> OnDelayRightChanged;
        public event EventHandler<IntDeviceEventArgs> OnFeedbackChanged;
        public event EventHandler<IntDeviceEventArgs> OnFeedbackLeftChanged;
        public event EventHandler<IntDeviceEventArgs> OnFeedbackRightChanged;
        public event EventHandler<IntDeviceEventArgs> OnFeedbackXfbRtLChanged;
        public event EventHandler<IntDeviceEventArgs> OnFeedbackXfbLtRChanged;
        public event EventHandler<EchoEffectStyleEventArgs> OnStyleChanged;
        public event EventHandler<IntDeviceEventArgs> OnTempoChanged;

        protected internal void HandleEvents(string serialNumber, EchoEffect effect, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged,
            EventHandler<CurrentEffectEventArgs> currentEffectChanged,
            EventHandler<EchoEffectEventArgs> echoChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.Current.Echo = new EchoEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.Amount;
                    effectEventArgs.Current.Echo.IntValue = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnAmountChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "DelayLeft":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.DelayLeft;
                    effectEventArgs.Current.Echo.IntValue = effect.DelayLeft;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnDelayLeftChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayLeft
                    });
                    break;
                
                case "DelayRight":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.DelayRight;
                    effectEventArgs.Current.Echo.IntValue = effect.DelayRight;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnDelayRightChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayRight
                    });
                    break;
                
                case "Feedback":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.Feedback;
                    effectEventArgs.Current.Echo.IntValue = effect.Feedback;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Feedback
                    });
                    break;
                
                case "FeedbackLeft":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackLeft;
                    effectEventArgs.Current.Echo.IntValue = effect.FeedbackLeft;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackLeftChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackLeft
                    });
                    break;
                
                case "FeedbackRight":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackRight;
                    effectEventArgs.Current.Echo.IntValue = effect.FeedbackRight;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackRightChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackRight
                    });
                    break;
                
                case "FeedbackXfbRtL":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackXfbRtL;
                    effectEventArgs.Current.Echo.IntValue = effect.FeedbackXfbRtL;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackXfbRtLChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackXfbRtL
                    });
                    break;
                
                case "FeedbackXfbLtR":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackXfbLtR;
                    effectEventArgs.Current.Echo.IntValue = effect.FeedbackXfbLtR;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackXfbLtRChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackXfbLtR
                    });
                    break;
                
                case "Style":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.Style;
                    effectEventArgs.Current.Echo.StyleValue = effect.Style;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnStyleChanged?.Invoke(this, new EchoEffectStyleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;
                
                case "Tempo":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.Tempo;
                    effectEventArgs.Current.Echo.IntValue = effect.Tempo;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnTempoChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Tempo
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EchoEffectEvents");
            }
        }
    }
}