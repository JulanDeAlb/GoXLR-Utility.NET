using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus
{
    public class SetFader : CommandBase
    {
        public SetFader(FaderEnum fader, FaderChannelEnum channel)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFader"] = new
                {
                    fader,
                    channel
                }
            };
        }
    }
}