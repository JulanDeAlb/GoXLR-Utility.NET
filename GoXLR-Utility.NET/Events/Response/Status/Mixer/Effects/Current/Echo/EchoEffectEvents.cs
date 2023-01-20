using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Echo
{
    public class EchoEffectEvents
    {
        public event EventHandler<IntEchoEffectEventArgs> OnAmountChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnDelayLeftChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnDelayRightChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnFeedbackChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnFeedbackLeftChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnFeedbackRightChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnFeedbackXfbRtLChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnFeedbackXfbLtRChanged;
        public event EventHandler<EchoEffectStyleEventArgs> OnStyleChanged;
        public event EventHandler<IntEchoEffectEventArgs> OnTempoChanged;

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
                    effectEventArgs.Current.Echo.Value = effect.Amount;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnAmountChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "DelayLeft":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.DelayLeft;
                    effectEventArgs.Current.Echo.Value = effect.DelayLeft;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnDelayLeftChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayLeft
                    });
                    break;
                
                case "DelayRight":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.DelayRight;
                    effectEventArgs.Current.Echo.Value = effect.DelayRight;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnDelayRightChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayRight
                    });
                    break;
                
                case "Feedback":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.Feedback;
                    effectEventArgs.Current.Echo.Value = effect.Feedback;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Feedback
                    });
                    break;
                
                case "FeedbackLeft":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackLeft;
                    effectEventArgs.Current.Echo.Value = effect.FeedbackLeft;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackLeftChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackLeft
                    });
                    break;
                
                case "FeedbackRight":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackRight;
                    effectEventArgs.Current.Echo.Value = effect.FeedbackRight;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackRightChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackRight
                    });
                    break;
                
                case "FeedbackXfbRtL":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackXfbRtL;
                    effectEventArgs.Current.Echo.Value = effect.FeedbackXfbRtL;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackXfbRtLChanged?.Invoke(this, new IntEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackXfbRtL
                    });
                    break;
                
                case "FeedbackXfbLtR":
                    effectEventArgs.Current.Echo.TypeChanged = EchoEnum.FeedbackXfbLtR;
                    effectEventArgs.Current.Echo.Value = effect.FeedbackXfbLtR;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnFeedbackXfbLtRChanged?.Invoke(this, new IntEchoEffectEventArgs
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
                    effectEventArgs.Current.Echo.Value = effect.Tempo;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    currentEffectChanged?.Invoke(this, effectEventArgs.Current);
                    echoChanged?.Invoke(this, effectEventArgs.Current.Echo);
                    OnTempoChanged?.Invoke(this, new IntEchoEffectEventArgs
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