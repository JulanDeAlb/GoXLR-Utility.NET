using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Fader;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetFaderDisplayStyle : CommandBase
    {
        public SetFaderDisplayStyle(FaderEnum fader, FaderDisplayStyle displayStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderDisplayStyle"] = new
                {
                    fader,
                    displayStyle
                }
            };
        }
    }
}