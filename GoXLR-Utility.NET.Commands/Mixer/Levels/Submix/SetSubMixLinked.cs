using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Submix
{
    public class SetSubMixLinked : DeviceCommandBase
    {
        /// <summary>
        /// Set whether the SubMix Channel should be linked or not.
        /// </summary>
        /// <param name="channel">The channel to edit</param>
        /// <param name="enabled">True if it should be linked or not</param>
        public SetSubMixLinked(InputDevice channel, bool enabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSubMixLinked"] = new object[]
                {
                    channel.ToString(),
                    enabled
                }
            };
        }
    }
}