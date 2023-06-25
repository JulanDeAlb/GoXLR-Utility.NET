using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Config;

namespace GoXLR_Utility.NET.Commands
{
    public class SetAllowNetworkAccess : NormalCommandBase
    {
        /// <summary>
        /// Set whether to allow network access.
        /// </summary>
        /// <param name="logLevel">True to allow</param>
        public SetAllowNetworkAccess(bool allow)
        {
            Command = new Dictionary<string, object>
            {
                ["SetAllowNetworkAccess"] = allow
            };
        }
    }
}