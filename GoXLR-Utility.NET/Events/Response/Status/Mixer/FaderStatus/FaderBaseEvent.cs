using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseEvent
    {
        public FaderScribbleEvents Scribble = new FaderScribbleEvents();
        
        public event EventHandler<FaderSettingsEventArgs> OnFaderSettingsChanged; 

        public event EventHandler<FaderChannelEventArgs> OnChannelChanged;
        
        public event EventHandler<FaderMuteTypeEventArgs> OnMuteTypeChanged;
        
        public event EventHandler<FaderMuteStateEventArgs> OnMuteStateChanged;

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo,
            EventHandler<FadersEventArgs> faderChangedEvent, FadersEventArgs fadersEventArgs)
        {
            var faderSettingsEventArgs = new FaderSettingsEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Channel":
                    fadersEventArgs.FaderSettingsEnum = faderSettingsEventArgs.FaderSettingsEnum = FaderSettingsEnum.Channel;
                    faderSettingsEventArgs.Fader = faderBase;
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, faderSettingsEventArgs);
                    OnChannelChanged?.Invoke(this, new FaderChannelEventArgs
                    {
                        SerialNumber = serialNumber,
                        Channel = faderBase.Channel
                    });
                    break;
                
                case "MuteType":
                    fadersEventArgs.FaderSettingsEnum = faderSettingsEventArgs.FaderSettingsEnum = FaderSettingsEnum.MuteType;
                    faderSettingsEventArgs.Fader = faderBase;
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, faderSettingsEventArgs);
                    OnMuteTypeChanged?.Invoke(this, new FaderMuteTypeEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteType = faderBase.MuteType
                    });
                    break;
                
                case "MuteState":
                    fadersEventArgs.FaderSettingsEnum = faderSettingsEventArgs.FaderSettingsEnum = FaderSettingsEnum.MuteState;
                    faderSettingsEventArgs.Fader = faderBase;
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, faderSettingsEventArgs);
                    OnMuteStateChanged?.Invoke(this, new FaderMuteStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteState = faderBase.MuteState
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in FaderBaseEvent");
            }
        }
    }
}