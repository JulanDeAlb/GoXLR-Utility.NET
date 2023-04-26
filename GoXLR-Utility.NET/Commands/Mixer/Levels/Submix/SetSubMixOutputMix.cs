using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels.Submix;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Submix
{
    public class SetSubMixOutputMix : DeviceCommandBase
    {
        /// <summary>
        /// Set which Submix Channel should be active on the Output.
        /// </summary>
        /// <param name="channel">The channel to edit</param>
        /// <param name="submixChannel">The submix channel to set to</param>
        public SetSubMixOutputMix(OutputDevice channel, SubmixOutput submixChannel)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSubMixLinked"] = new object[]
                {
                    channel.ToString(),
                    submixChannel.ToString()
                }
            };
        }
    }
}