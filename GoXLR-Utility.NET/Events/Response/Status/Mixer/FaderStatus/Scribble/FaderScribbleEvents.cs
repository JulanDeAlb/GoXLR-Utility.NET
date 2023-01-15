using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
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
            EventHandler<FaderScribbleEventArgs> faderChangedEvent, FaderScribbleEventArgs scribbleEventArgs)
        {
            var faderBaseScribbleEventArgs = new FaderBaseScribbleEventArgs
            {
                SerialNumber = serialNumber,
                Scribble = scribble
            };

            switch (memInfo.Name)
            {
                case "BottomText":
                    scribbleEventArgs.ScribbleEnum = faderBaseScribbleEventArgs.ScribbleEnum = ScribbleEnum.BottomText;
                    faderChangedEvent?.Invoke(this, scribbleEventArgs);
                    OnScribbleChanged?.Invoke(this, faderBaseScribbleEventArgs);
                    OnBottomTextChanged?.Invoke(this, new ScribbleBottomTextEventArgs
                    {
                        SerialNumber = serialNumber,
                        BottomText = scribble.BottomText
                    });
                    break;

                case "FileName":
                    scribbleEventArgs.ScribbleEnum = faderBaseScribbleEventArgs.ScribbleEnum = ScribbleEnum.BottomText;
                    faderChangedEvent?.Invoke(this, scribbleEventArgs);
                    OnScribbleChanged?.Invoke(this, faderBaseScribbleEventArgs);
                    OnFileNameChanged?.Invoke(this, new ScribbleFileNameEventArgs
                    {
                        SerialNumber = serialNumber,
                        FileName = scribble.FileName
                    });
                    break;

                case "Inverted":
                    scribbleEventArgs.ScribbleEnum = faderBaseScribbleEventArgs.ScribbleEnum = ScribbleEnum.BottomText;
                    faderChangedEvent?.Invoke(this, scribbleEventArgs);
                    OnScribbleChanged?.Invoke(this, faderBaseScribbleEventArgs);
                    OnInvertedChanged?.Invoke(this, new ScribbleInvertedEventArgs
                    {
                        SerialNumber = serialNumber,
                        Inverted = scribble.Inverted
                    });
                    break;

                case "LeftText":
                    scribbleEventArgs.ScribbleEnum = faderBaseScribbleEventArgs.ScribbleEnum = ScribbleEnum.BottomText;
                    faderChangedEvent?.Invoke(this, scribbleEventArgs);
                    OnScribbleChanged?.Invoke(this, faderBaseScribbleEventArgs);
                    OnLeftTextChanged?.Invoke(this, new ScribbleLeftTextEventArgs
                    {
                        SerialNumber = serialNumber,
                        LeftText = scribble.LeftText
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in FaderScribbleEvents");
            }
        }
    }
}