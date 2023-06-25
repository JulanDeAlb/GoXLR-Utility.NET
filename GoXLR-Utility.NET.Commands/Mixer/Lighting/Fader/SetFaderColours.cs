using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetFaderColours : DeviceCommandBase
    {
        /// <summary>
        /// Set the Faders Colours.
        /// </summary>
        /// <param name="fader">The Fader to edit</param>
        /// <param name="colour1">The Colour 1 (#ffffff)</param>
        /// <param name="colour2">The Colour 2 (#ffffff)</param>
        public SetFaderColours(FaderName fader, string colour1, string colour2)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetFaderColours"] = new object[]
                {
                    fader.ToString(),
                    colour1,
                    colour2
                }
            };
        }
    }
}