using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.FaderStatus.Scribble
{
    /// <summary>
    /// <seealso cref="FaderScribble"/>
    /// </summary>
    public class FaderScribbleEvents
    {
        public event EventHandler<FaderBaseScribbleEventArgs> OnScribbleChanged;
        
        public event EventHandler<StringScribbleEventArgs> OnBottomTextChanged;
        
        public event EventHandler<StringScribbleEventArgs> OnFileNameChanged;
        
        public event EventHandler<BoolScribbleEventArgs> OnInvertedChanged;
        
        public event EventHandler<StringScribbleEventArgs> OnLeftTextChanged;
        
        protected internal void HandleEvents(string serialNumber, FaderScribble scribble, MemberInfo memInfo,
            EventHandler<FadersEventArgs> faderChangedEvent,
            EventHandler<FaderScribbleEventArgs> scribbleEvent,
            FadersEventArgs fadersEventArgs)
        {
            fadersEventArgs.Fader.Scribble = new FaderScribbleEventArgs
            {
                SerialNumber = serialNumber,
                FaderBase = new FaderBaseScribbleEventArgs
                {
                    SerialNumber = serialNumber
                }
            };

            switch (memInfo.Name)
            {
                case "BottomText":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.BottomText;
                    fadersEventArgs.Fader.Scribble.FaderBase.StringValue = scribble.BottomText;
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnBottomTextChanged?.Invoke(this, new StringScribbleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble.BottomText
                    });
                    break;

                case "FileName":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.FileName;
                    fadersEventArgs.Fader.Scribble.FaderBase.StringValue = scribble.FileName;
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnFileNameChanged?.Invoke(this, new StringScribbleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble.FileName
                    });
                    break;

                case "Inverted":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.Inverted;
                    fadersEventArgs.Fader.Scribble.FaderBase.BoolValue = scribble.Inverted;
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnInvertedChanged?.Invoke(this, new BoolScribbleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble.Inverted
                    });
                    break;

                case "LeftText":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.LeftText;
                    fadersEventArgs.Fader.Scribble.FaderBase.StringValue = scribble.LeftText;
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnLeftTextChanged?.Invoke(this, new StringScribbleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = scribble.LeftText
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in FaderScribbleEvents");
            }
        }
    }
}