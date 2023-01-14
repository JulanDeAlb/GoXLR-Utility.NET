using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus
{
    /// <summary>
    /// <seealso cref="FaderStatus"/>
    /// </summary>
    public class FaderStatusEvents
    {
        public FaderScribbleEvents Scribble = new FaderScribbleEvents();
        public FaderBaseEvent FaderA = new FaderBaseEvent();
        public FaderBaseEvent FaderB = new FaderBaseEvent();
        public FaderBaseEvent FaderC = new FaderBaseEvent();
        public FaderBaseEvent FaderD = new FaderBaseEvent();

        public event EventHandler<FaderStatusEventArgs> OnFaderChanged;
        
        public event EventHandler<SpecificFaderStatusEventArgs> OnFaderAChanged;
        
        public event EventHandler<SpecificFaderStatusEventArgs> OnFaderBChanged;
        
        public event EventHandler<SpecificFaderStatusEventArgs> OnFaderCChanged;
        
        public event EventHandler<SpecificFaderStatusEventArgs> OnFaderDChanged;

        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, MemberInfo memInfo)
        {
            var faderStatusEventArgs = new FaderStatusEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            var specFaderStatusEventArgs = new SpecificFaderStatusEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (faderBase)
            {
                case FaderA faderA:
                    faderStatusEventArgs.FaderEnum = FaderEnum.A;
                    faderStatusEventArgs.Fader = specFaderStatusEventArgs.Fader = faderA;
                    OnFaderChanged?.Invoke(this, faderStatusEventArgs);
                    OnFaderAChanged?.Invoke(this, specFaderStatusEventArgs);
                    FaderA.HandleEvents(serialNumber, faderA, memInfo);
                    break;
                    
                case FaderB faderB:
                    faderStatusEventArgs.FaderEnum = FaderEnum.B;
                    faderStatusEventArgs.Fader = specFaderStatusEventArgs.Fader = faderB;
                    OnFaderChanged?.Invoke(this, faderStatusEventArgs);
                    OnFaderBChanged?.Invoke(this, specFaderStatusEventArgs);
                    FaderB.HandleEvents(serialNumber, faderB, memInfo);
                    break;
                    
                case FaderC faderC:
                    faderStatusEventArgs.FaderEnum = FaderEnum.C;
                    faderStatusEventArgs.Fader = specFaderStatusEventArgs.Fader = faderC;
                    OnFaderChanged?.Invoke(this, faderStatusEventArgs);
                    OnFaderCChanged?.Invoke(this, specFaderStatusEventArgs);
                    FaderC.HandleEvents(serialNumber, faderC, memInfo);
                    break;
                    
                case FaderD faderD:
                    faderStatusEventArgs.FaderEnum = FaderEnum.D;
                    faderStatusEventArgs.Fader = specFaderStatusEventArgs.Fader = faderD;
                    OnFaderChanged?.Invoke(this, faderStatusEventArgs);
                    OnFaderDChanged?.Invoke(this, specFaderStatusEventArgs);
                    FaderD.HandleEvents(serialNumber, faderD, memInfo);
                    break;
                
                default:
                    var type = faderBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in FaderStatus: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}