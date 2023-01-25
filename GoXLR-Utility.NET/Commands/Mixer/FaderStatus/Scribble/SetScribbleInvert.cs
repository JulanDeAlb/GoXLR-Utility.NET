using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleInvert : CommandBase
    {
        public SetScribbleInvert(FaderEnum fader, bool invert)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleInvert"] = new
                {
                    fader,
                    invert
                }
            };
        }
    }
}