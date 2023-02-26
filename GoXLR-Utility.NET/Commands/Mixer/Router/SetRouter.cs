using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Router
{
    public class SetRouter : DeviceCommandBase
    {
        /// <summary>
        /// Set the Routing of the Device
        /// </summary>
        /// <param name="input">Input Channel</param>
        /// <param name="output">Output Channel</param>
        /// <param name="isEnabled">State of the Routing</param>
        public SetRouter(InputDevice input, OutputDevice output, bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRouter"] = new object[]
                {
                    input.ToString(),
                    output.ToString(),
                    isEnabled.ToString()
                }
            };
        }
    }
}