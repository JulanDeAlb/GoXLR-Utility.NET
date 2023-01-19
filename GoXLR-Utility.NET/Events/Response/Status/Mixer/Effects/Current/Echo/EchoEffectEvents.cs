using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current.Echo;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current.Echo
{
    public class EchoEffectEvents
    {
        public event EventHandler<EchoEffectEventArgs> OnEchoEffectChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnAmountChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnDelayLeftChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnDelayRightChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnFeedbackChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnFeedbackLeftChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnFeedbackRightChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnFeedbackXfbRtLChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnFeedbackXfbLtRChanged;
        public event EventHandler<EchoEffectStyleEventArgs> OnStyleChanged;
        public event EventHandler<SpecificEchoEffectEventArgs> OnTempoChanged;

        protected internal void HandleEvents(string serialNumber, EchoEffect effect, MemberInfo memInfo)
        {
            var echoEffectEventArgs = new EchoEffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Amount":
                    echoEffectEventArgs.TypeChanged = EchoEnum.Amount;
                    echoEffectEventArgs.Value = effect.Amount;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnAmountChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Amount
                    });
                    break;
                
                case "DelayLeft":
                    echoEffectEventArgs.TypeChanged = EchoEnum.DelayLeft;
                    echoEffectEventArgs.Value = effect.DelayLeft;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnDelayLeftChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayLeft
                    });
                    break;
                
                case "DelayRight":
                    echoEffectEventArgs.TypeChanged = EchoEnum.DelayRight;
                    echoEffectEventArgs.Value = effect.DelayRight;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnDelayRightChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.DelayRight
                    });
                    break;
                
                case "Feedback":
                    echoEffectEventArgs.TypeChanged = EchoEnum.Feedback;
                    echoEffectEventArgs.Value = effect.Feedback;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnFeedbackChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Feedback
                    });
                    break;
                
                case "FeedbackLeft":
                    echoEffectEventArgs.TypeChanged = EchoEnum.FeedbackLeft;
                    echoEffectEventArgs.Value = effect.FeedbackLeft;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnFeedbackLeftChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackLeft
                    });
                    break;
                
                case "FeedbackRight":
                    echoEffectEventArgs.TypeChanged = EchoEnum.FeedbackRight;
                    echoEffectEventArgs.Value = effect.FeedbackRight;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnFeedbackRightChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackRight
                    });
                    break;
                
                case "FeedbackXfbRtL":
                    echoEffectEventArgs.TypeChanged = EchoEnum.FeedbackXfbRtL;
                    echoEffectEventArgs.Value = effect.FeedbackXfbRtL;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnFeedbackXfbRtLChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackXfbRtL
                    });
                    break;
                
                case "FeedbackXfbLtR":
                    echoEffectEventArgs.TypeChanged = EchoEnum.FeedbackXfbLtR;
                    echoEffectEventArgs.Value = effect.FeedbackXfbLtR;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnFeedbackXfbLtRChanged?.Invoke(this, new SpecificEchoEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.FeedbackXfbLtR
                    });
                    break;
                
                case "Style":
                    echoEffectEventArgs.TypeChanged = EchoEnum.Style;
                    echoEffectEventArgs.EchoStyle = effect.Style;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnStyleChanged?.Invoke(this, new EchoEffectStyleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effect.Style
                    });
                    break;
                
                case "Tempo":
                    echoEffectEventArgs.TypeChanged = EchoEnum.Tempo;
                    echoEffectEventArgs.Value = effect.Tempo;
                    
                    OnEchoEffectChanged?.Invoke(this, echoEffectEventArgs);
                    OnTempoChanged?.Invoke(this, new SpecificEchoEffectEventArgs
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