using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus
{
    public class SetFader : DeviceCommandBase
    {
        /// <summary>
        /// Set a Channel of a certain Fader
        /// </summary>
        /// <param name="fader">Fader to edit</param>
        /// <param name="channel">Channel to set</param>
        public SetFader(FaderName fader, ChannelName channel)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFader"] = new object[]
                {
                    fader.ToString(),
                    channel.ToString()
                }
            };
        }
    }
}