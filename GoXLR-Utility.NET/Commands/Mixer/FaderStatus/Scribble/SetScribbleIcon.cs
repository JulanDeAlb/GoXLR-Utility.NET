using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleIcon : DeviceCommandBase
    {
        /// <summary>
        /// Set the Scribble Icon of a Fader (Display)
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="filename">The FileName to apply</param>
        public SetScribbleIcon(FaderName fader, string filename)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleIcon"] = new object[]
                {
                    fader.ToString(),
                    filename
                }
            };
        }
    }
}