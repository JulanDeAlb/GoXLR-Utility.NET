using System.Collections.Generic;
using System.Linq;

namespace GoXLR_Utility.NET.Commands.Mixer.ShutdownCommands
{
    public class ResetShutdownCommands : DeviceCommandBase
    {
        /// <summary>
        /// Reset Commands that should be executed on shutdown.
        /// </summary>
        public ResetShutdownCommands()
        {
            Command = new Dictionary<string, object>
            {
                ["SetShutdownCommands"] = new object[] { }
            };
        }
    }
}