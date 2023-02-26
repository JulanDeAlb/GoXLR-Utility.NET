using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetAllFaderDisplayStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Display Style of all Faders.
        /// </summary>
        /// <param name="displayStyle">The Display Style to set</param>
        public SetAllFaderDisplayStyle(FaderDisplayStyle displayStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetAllFaderDisplayStyle"] = new object[]
                {
                    displayStyle.ToString()
                }
            };
        }
    }
}