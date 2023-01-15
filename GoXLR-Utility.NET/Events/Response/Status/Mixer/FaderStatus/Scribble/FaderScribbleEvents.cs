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
        
        public event EventHandler<ScribbleBottomTextEventArgs> OnBottomTextChanged;
        
        public event EventHandler<ScribbleFileNameEventArgs> OnFileNameChanged;
        
        public event EventHandler<ScribbleInvertedEventArgs> OnInvertedChanged;
        
        public event EventHandler<ScribbleLeftTextEventArgs> OnLeftTextChanged;
        
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
                    fadersEventArgs.Fader.Scribble.FaderBase.BottomText = new ScribbleBottomTextEventArgs
                    {
                        SerialNumber = serialNumber,
                        BottomText = scribble.BottomText
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnBottomTextChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase.BottomText);
                    break;

                case "FileName":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.FileName;
                    fadersEventArgs.Fader.Scribble.FaderBase.FileName = new ScribbleFileNameEventArgs
                    {
                        SerialNumber = serialNumber,
                        FileName = scribble.FileName
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnFileNameChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase.FileName);
                    break;

                case "Inverted":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.Inverted;
                    fadersEventArgs.Fader.Scribble.FaderBase.Inverted = new ScribbleInvertedEventArgs
                    {
                        SerialNumber = serialNumber,
                        Inverted = scribble.Inverted
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnInvertedChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase.Inverted);
                    break;

                case "LeftText":
                    fadersEventArgs.Fader.Scribble.FaderBase.TypeChanged = ScribbleEnum.LeftText;
                    fadersEventArgs.Fader.Scribble.FaderBase.LeftText = new ScribbleLeftTextEventArgs
                    {
                        SerialNumber = serialNumber,
                        LeftText = scribble.LeftText
                    };
                    
                    faderChangedEvent?.Invoke(this, fadersEventArgs);
                    scribbleEvent?.Invoke(this, fadersEventArgs.Fader.Scribble);
                    OnScribbleChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase);
                    OnLeftTextChanged?.Invoke(this, fadersEventArgs.Fader.Scribble.FaderBase.LeftText);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in FaderScribbleEvents");
            }
        }
    }
}