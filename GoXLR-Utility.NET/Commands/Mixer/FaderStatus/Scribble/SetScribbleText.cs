using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleText : DeviceCommandBase
    {
        /// <summary>
        /// Set the Scribble Text to be displayed (Display)
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="text">The text to set</param>
        public SetScribbleText(FaderName fader, string text)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleText"] = new object[]
                {
                    fader.ToString(),
                    text
                }
            };
        }
    }
}