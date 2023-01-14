using System;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble
{
    /// <summary>
    /// <seealso cref="FaderScribble"/>
    /// </summary>
    public class FaderScribbleEvents
    {
        public event EventHandler<FaderScribbleEventArgs> OnFaderScribbleChanged;

        public event EventHandler<SpecificFaderScribbleEventArgs> OnFaderScribbleAChanged;
        
        public event EventHandler<SpecificFaderScribbleEventArgs> OnFaderScribbleBChanged;
        
        public event EventHandler<SpecificFaderScribbleEventArgs> OnFaderScribbleCChanged;
        
        public event EventHandler<SpecificFaderScribbleEventArgs> OnFaderScribbleDChanged;
        
        protected internal void HandleEvents(string serialNumber, FaderBase faderBase, FaderScribble scribble)
        {
            var faderScribbleEventArgs = new FaderScribbleEventArgs
            {
                SerialNumber = serialNumber,
                BottomText = scribble.BottomText,
                FileName = scribble.FileName,
                Inverted = scribble.Inverted,
                LeftText = scribble.LeftText
            };

            var specFaderScribbleEventArgs = new SpecificFaderScribbleEventArgs
            {
                SerialNumber = serialNumber,
                BottomText = scribble.BottomText,
                FileName = scribble.FileName,
                Inverted = scribble.Inverted,
                LeftText = scribble.LeftText
            };
            
            switch (faderBase)
            {
                case FaderA faderA:
                    faderScribbleEventArgs.FaderName = FaderName.A;
                    OnFaderScribbleChanged?.Invoke(this, faderScribbleEventArgs);
                    OnFaderScribbleAChanged?.Invoke(this, specFaderScribbleEventArgs);
                    break;
                    
                case FaderB faderB:
                    faderScribbleEventArgs.FaderName = FaderName.B;
                    OnFaderScribbleChanged?.Invoke(this, faderScribbleEventArgs);
                    OnFaderScribbleBChanged?.Invoke(this, specFaderScribbleEventArgs);
                    break;
                    
                case FaderC faderC:
                    faderScribbleEventArgs.FaderName = FaderName.C;
                    OnFaderScribbleChanged?.Invoke(this, faderScribbleEventArgs);
                    OnFaderScribbleCChanged?.Invoke(this, specFaderScribbleEventArgs);
                    break;
                    
                case FaderD faderD:
                    faderScribbleEventArgs.FaderName = FaderName.D;
                    OnFaderScribbleChanged?.Invoke(this, faderScribbleEventArgs);
                    OnFaderScribbleDChanged?.Invoke(this, specFaderScribbleEventArgs);
                    break;
                
                default:
                    var type = faderBase.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in Scribble: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}