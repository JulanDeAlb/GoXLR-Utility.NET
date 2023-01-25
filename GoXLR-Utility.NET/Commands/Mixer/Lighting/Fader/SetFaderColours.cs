using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Fader
{
    public class SetFaderColours : CommandBase
    {
        public SetFaderColours(FaderEnum fader, string colour1, string colour2)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderColours"] = new
                {
                    fader,
                    colour1,
                    colour2
                }
            };
        }
    }
}