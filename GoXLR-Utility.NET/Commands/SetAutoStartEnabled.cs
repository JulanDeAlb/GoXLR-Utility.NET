using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands
{
    public class SetAutoStartEnabled : NormalCommandBase
    {
        /// <summary>
        /// Enable or disable the Autostart
        /// </summary>
        /// <param name="enable">True to enable</param>
        public SetAutoStartEnabled(bool enable)
        {
            Command = new Dictionary<string, object>
            {
                ["SetAutoStartEnabled"] = enable
            };
        }
    }
}