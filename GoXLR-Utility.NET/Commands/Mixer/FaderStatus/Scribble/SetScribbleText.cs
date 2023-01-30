using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleText : CommandBase
    {
        public SetScribbleText(FaderEnum fader, string text)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleText"] = new
                {
                    fader,
                    text
                }
            };
        }
    }
}