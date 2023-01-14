using System;
using System.Reflection;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus
{
    public class FaderBaseEvent
    {
        public event EventHandler<FaderBaseChannelEventArgs> OnChannelChanged;
        
        public event EventHandler<FaderBaseMuteTypeEventArgs> OnMuteTypeChanged;
        
        public event EventHandler<FaderBaseMuteStateEventArgs> OnMuteStateChanged;
        
        public event EventHandler<FaderBaseScribbleEventArgs> OnScribbleChanged;

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo)
        {
            switch (memInfo.Name)
            {
                case "Channel":
                    OnChannelChanged?.Invoke(this, new FaderBaseChannelEventArgs
                    {
                        SerialNumber = serialNumber,
                        Channel = faderBase.Channel
                    });
                    break;
                
                case "MuteType":
                    OnMuteTypeChanged?.Invoke(this, new FaderBaseMuteTypeEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteType = faderBase.MuteType
                    });
                    break;
                
                case "MuteState":
                    OnMuteStateChanged?.Invoke(this, new FaderBaseMuteStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteState = faderBase.MuteState
                    });
                    break;
                
                case "Scribble":
                    OnScribbleChanged?.Invoke(this, new FaderBaseScribbleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Scribble = faderBase.Scribble
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in FaderBaseEvent");
            }
        }
    }
}