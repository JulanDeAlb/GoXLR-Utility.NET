using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Config;

namespace GoXLR_Utility.NET.Commands
{
    public class SetLogLevel : NormalCommandBase
    {
        /// <summary>
        /// Set the Daemons Loglevel
        /// </summary>
        /// <param name="logLevel">The LogLevel to apply</param>
        public SetLogLevel(LogLevelEnum logLevel)
        {
            Command = new Dictionary<string, object>
            {
                ["SetLogLevel"] = logLevel.ToString()
            };
        }
    }
}