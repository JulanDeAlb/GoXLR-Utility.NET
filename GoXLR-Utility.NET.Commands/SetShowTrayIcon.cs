using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands
{
    public class SetShowTrayIcon : NormalCommandBase
    {
        /// <summary>
        /// Enable or disable the Tray Icon
        /// </summary>
        /// <param name="showIcon">True to enable</param>
        public SetShowTrayIcon(bool showIcon)
        {
            Command = new Dictionary<string, object>
            {
                ["SetShowTrayIcon"] = showIcon
            };
        }
    }
}