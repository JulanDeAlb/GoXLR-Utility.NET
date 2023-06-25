using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleNumber : DeviceCommandBase
    {
        /// <summary>
        /// Set the String that should be displayed on the Scribble on the Number position(Display)<br/>
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="string">The String to display</param>
        public SetScribbleNumber(FaderName fader, string @string)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleNumber"] = new object[]
                {
                    fader.ToString(),
                    @string
                }
            };
        }

        /// <summary>
        /// Set the Number/String that should be displayed on the Scribble (Display)<br/>
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="number">The String to display</param>
        public SetScribbleNumber(FaderName fader, int number)
        {
            _ = new SetScribbleNumber(fader, number.ToString());
        }

        /// <summary>
        /// Set the Number that should be displayed on the Scribble (Display)
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="showNumber">State of the Number</param>
        public SetScribbleNumber(FaderName fader, bool showNumber)
        {
            string number;

            switch (fader)
            {
                case FaderName.A:
                    number = showNumber ? "1" : "0";
                    break;

                case FaderName.B:
                    number = showNumber ? "2" : "0";
                    break;

                case FaderName.C:
                    number = showNumber ? "3" : "0";
                    break;

                case FaderName.D:
                    number = showNumber ? "4" : "0";
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(fader), fader, null);
            }

            _ = new SetScribbleNumber(fader, number);
        }
    }
}