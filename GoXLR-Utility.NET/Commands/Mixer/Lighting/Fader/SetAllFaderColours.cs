using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetAllFaderColours : DeviceCommandBase
    {
        /// <summary>
        /// Set the Colours of all Faders.
        /// </summary>
        /// <param name="colour1">The Colour 1 (#ffffff)</param>
        /// <param name="colour2">The Colour 2 (#ffffff)</param>
        public SetAllFaderColours(string colour1, string colour2)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetAllFaderColours"] = new object[]
                {
                    colour1,
                    colour2
                }
            };
        }
    }
}