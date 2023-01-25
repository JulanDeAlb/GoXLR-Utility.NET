using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus.Scribble
{
    public class SetScribbleIcon : CommandBase
    {
        public SetScribbleIcon(FaderEnum fader, string filename)
        {
            Command = new Dictionary<string, object>
            {
                ["SetScribbleIcon"] = new
                {
                    fader,
                    filename
                }
            };
        }
    }
}