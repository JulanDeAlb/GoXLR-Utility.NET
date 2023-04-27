using System.Collections.Generic;
using System.Linq;

namespace GoXLR_Utility.NET.Commands.Mixer.ShutdownCommands
{
    public class SetShutdownCommands : DeviceCommandBase
    {
        /// <summary>
        /// Set Commands that should be executed on shutdown.
        /// </summary>
        /// <param name="command">The command to add to set</param>
        public SetShutdownCommands(DeviceCommandBase command)
        {
            Command = new Dictionary<string, object>
            {
                ["SetShutdownCommands"] = new object[]
                {
                    command.Command
                }
            };
        }
        
        /// <summary>
        /// Set Commands that should be executed on shutdown.
        /// </summary>
        /// <param name="commands">The Enumerable commands to set</param>
        public SetShutdownCommands(IEnumerable<DeviceCommandBase> commands)
        {
            Command = new Dictionary<string, object>
            {
                ["SetShutdownCommands"] = commands.Select(command => command.Command).Cast<object>().ToArray()
            };
        }
    }
}