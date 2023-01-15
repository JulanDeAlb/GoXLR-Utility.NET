using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus
{
    /// <summary>
    /// <seealso cref="FaderStatus"/>
    /// </summary>
    public class FaderStatusEvents
    {
        public FaderBaseEvent FaderA = new FaderBaseEvent();
        public FaderBaseEvent FaderB = new FaderBaseEvent();
        public FaderBaseEvent FaderC = new FaderBaseEvent();
        public FaderBaseEvent FaderD = new FaderBaseEvent();

        public event EventHandler<FadersEventArgs> OnFadersChanged;

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo,
            FaderScribble scribble)
        {
            var eventArgs = new FadersEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (faderBase)
            {
                case FaderA faderA:
                    eventArgs.TypeChanged = FaderEnum.A;

                    FaderA.HandleEvents(serialNumber, faderA, memInfo, OnFadersChanged, eventArgs, scribble);
                    break;

                case FaderB faderB:
                    eventArgs.TypeChanged = FaderEnum.B;

                    FaderB.HandleEvents(serialNumber, faderB, memInfo, OnFadersChanged, eventArgs, scribble);
                    break;

                case FaderC faderC:
                    eventArgs.TypeChanged = FaderEnum.C;

                    FaderC.HandleEvents(serialNumber, faderC, memInfo, OnFadersChanged, eventArgs, scribble);
                    break;

                case FaderD faderD:
                    eventArgs.TypeChanged = FaderEnum.D;

                    FaderD.HandleEvents(serialNumber, faderD, memInfo, OnFadersChanged, eventArgs, scribble);
                    break;

                default:
                    var type = faderBase.GetType();
                    throw new ArgumentOutOfRangeException(
                        $"Type out of Range in FaderStatus: {type.Name} | Path: {type.FullName}");
            }
        }
    }

    /// <summary>
    /// <seealso cref="FaderBase"/>
    /// </summary>
    public class FaderBaseEvent
    {
        public FaderScribbleEvents Scribble = new FaderScribbleEvents();

        public event EventHandler<FaderSettingsEventArgs> OnFaderSettingsChanged; 

        public event EventHandler<FaderChannelEventArgs> OnChannelChanged;
        
        public event EventHandler<FaderMuteTypeEventArgs> OnMuteTypeChanged;
        
        public event EventHandler<FaderMuteStateEventArgs> OnMuteStateChanged;
        
        public event EventHandler<FaderScribbleEventArgs> OnScribbleChanged;

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo,
            EventHandler<FadersEventArgs> faderChangedEvent, FadersEventArgs fadersEventArgs, FaderScribble scribble)
        {
            fadersEventArgs.Fader = new FaderSettingsEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Channel":
                    fadersEventArgs.Fader.TypeChanged = FaderSettingsEnum.Channel;
                    fadersEventArgs.Fader.Channel = new FaderChannelEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = faderBase.Channel
                    };

                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, fadersEventArgs.Fader);
                    OnChannelChanged?.Invoke(this, fadersEventArgs.Fader.Channel);
                    break;
                
                case "MuteType":
                    fadersEventArgs.Fader.TypeChanged = FaderSettingsEnum.MuteType;
                    fadersEventArgs.Fader.MuteType = new FaderMuteTypeEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = faderBase.MuteType
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, fadersEventArgs.Fader);
                    OnMuteTypeChanged?.Invoke(this, fadersEventArgs.Fader.MuteType);
                    break;
                
                case "MuteState":
                    fadersEventArgs.Fader.TypeChanged = FaderSettingsEnum.MuteState;
                    fadersEventArgs.Fader.MuteState = new FaderMuteStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = faderBase.MuteState
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    OnFaderSettingsChanged?.Invoke(this, fadersEventArgs.Fader);
                    OnMuteStateChanged?.Invoke(this, fadersEventArgs.Fader.MuteState);
                    break;
                
                default:
                    if (scribble == null)
                        throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in FaderBaseEvent");

                    Scribble.HandleEvents(serialNumber, scribble, memInfo, faderChangedEvent, OnScribbleChanged, fadersEventArgs);
                    break;
            }
        }
    }
}