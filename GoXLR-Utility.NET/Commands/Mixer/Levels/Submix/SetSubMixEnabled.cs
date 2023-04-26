using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Submix
{
    public class SetSubMixEnabled : DeviceCommandBase
    {
        /// <summary>
        /// Set whether the SubMix is enabled or not.
        /// </summary>
        /// <param name="enabled">True if it should be enabled</param>
        public SetSubMixEnabled(bool enabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSubMixEnabled"] = new object[]
                {
                    enabled.ToString()
                }
            };
        }
    }
}