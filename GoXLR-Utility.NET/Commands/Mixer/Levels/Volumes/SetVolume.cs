using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Volumes
{
    public class SetVolume : CommandBase
    {
        public SetVolume(FaderChannelEnum channel, byte volume)
        {
            Command = new Dictionary<string, object>
            {
                ["SetVolume"] = new
                {
                    channel,
                    volume
                }
            };
        }
    }
}