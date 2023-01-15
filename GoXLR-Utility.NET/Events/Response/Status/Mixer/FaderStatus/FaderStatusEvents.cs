using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
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
        public event EventHandler<FaderScribbleEventArgs> OnFaderScribbleChanged; 

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo)
        {
            var eventArgs = new FadersEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (faderBase)
            {
                case FaderA faderA:
                    eventArgs.FaderEnum = FaderEnum.A;
                    eventArgs.Fader = faderA;
                    FaderA.HandleEvents(serialNumber, faderA, memInfo, OnFadersChanged, eventArgs);
                    break;
                    
                case FaderB faderB:
                    eventArgs.FaderEnum = FaderEnum.B;
                    eventArgs.Fader = faderB;
                    FaderB.HandleEvents(serialNumber, faderB, memInfo, OnFadersChanged, eventArgs);
                    break;
                    
                case FaderC faderC:
                    eventArgs.FaderEnum = FaderEnum.C;
                    eventArgs.Fader = faderC;
                    FaderC.HandleEvents(serialNumber, faderC, memInfo, OnFadersChanged, eventArgs);
                    break;
                    
                case FaderD faderD:
                    eventArgs.FaderEnum = FaderEnum.D;
                    eventArgs.Fader = faderD;
                    FaderD.HandleEvents(serialNumber, faderD, memInfo, OnFadersChanged, eventArgs);
                    break;
                
                default:
                    var type = faderBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in FaderStatus: {type.Name} | Path: {type.FullName}");
            }
        }

        public void HandleScribbleEvents(string serialNumber, FaderBase faderBase, FaderScribble scribble, MemberInfo memInfo)
        {
            var scribbleEventArgs = new FaderScribbleEventArgs
            {
                SerialNumber = serialNumber,
                Scribble = scribble
            };
            
            switch (faderBase)
            {
                case FaderA _:
                    scribbleEventArgs.FaderEnum = FaderEnum.A;
                    OnFaderScribbleChanged?.Invoke(this, scribbleEventArgs);
                    FaderA.Scribble.HandleEvents(serialNumber, scribble, memInfo, OnFaderScribbleChanged, scribbleEventArgs);
                    break;
                    
                case FaderB _:
                    scribbleEventArgs.FaderEnum = FaderEnum.A;
                    OnFaderScribbleChanged?.Invoke(this, scribbleEventArgs);
                    FaderB.Scribble.HandleEvents(serialNumber, scribble, memInfo, OnFaderScribbleChanged, scribbleEventArgs);
                    break;
                    
                case FaderC _:
                    scribbleEventArgs.FaderEnum = FaderEnum.A;
                    OnFaderScribbleChanged?.Invoke(this, scribbleEventArgs);
                    FaderC.Scribble.HandleEvents(serialNumber, scribble, memInfo, OnFaderScribbleChanged, scribbleEventArgs);
                    break;
                    
                case FaderD _:
                    scribbleEventArgs.FaderEnum = FaderEnum.A;
                    OnFaderScribbleChanged?.Invoke(this, scribbleEventArgs);
                    FaderD.Scribble.HandleEvents(serialNumber, scribble, memInfo, OnFaderScribbleChanged, scribbleEventArgs);
                    break;
                
                default:
                    var type = faderBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in FaderStatus: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}