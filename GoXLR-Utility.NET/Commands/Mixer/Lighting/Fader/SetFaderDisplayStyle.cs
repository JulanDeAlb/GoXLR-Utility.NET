using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetFaderDisplayStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Fader Display Style.
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="displayStyle">The Display Style to set</param>
        public SetFaderDisplayStyle(FaderName fader, FaderDisplayStyle displayStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderDisplayStyle"] = new object[]
                {
                    fader.ToString(),
                    displayStyle.ToString()
                }
            };
        }
    }
}