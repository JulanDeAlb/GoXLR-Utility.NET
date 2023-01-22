using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus
{
    public class SetFaderMuteFunction : CommandBase
    {
        public SetFaderMuteFunction(FaderEnum fader, MuteFunction function)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderMuteFunction"] = new
                {
                    fader,
                    function
                }
            };
        }
    }
}