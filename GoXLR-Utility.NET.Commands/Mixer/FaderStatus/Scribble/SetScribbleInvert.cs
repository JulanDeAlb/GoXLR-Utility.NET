using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleInvert : DeviceCommandBase
    {
        /// <summary>
        /// Set the Scribble to be displayed inverted (Display)
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="invert">State of the invert</param>
        public SetScribbleInvert(FaderName fader, bool invert)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleInvert"] = new object[]
                {
                    fader.ToString(),
                    invert
                }
            };
        }
    }
}