using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Submix
{
    public class SetMonitorMix : DeviceCommandBase
    {
        /// <summary>
        /// Set your Monitor Mix.
        /// </summary>
        /// <param name="enabled">True if it should be enabled</param>
        public SetMonitorMix(OutputDevice output)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMonitorMix"] = output.ToString()
            };
        }
    }
}