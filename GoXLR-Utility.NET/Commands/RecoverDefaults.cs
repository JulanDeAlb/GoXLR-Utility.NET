using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;

namespace GoXLR_Utility.NET.Commands
{
    public class RecoverDefaults : CommandBase
    {
        /// <summary>
        /// Recover defaults like default Profiles etc.
        /// </summary>
        /// <param name="path">The type to recover the defaults</param>
        public RecoverDefaults(PathEnum path)
        {
            Command = new Dictionary<string, object>
            {
                ["RecoverDefaults"] = new object[]
                {
                    path.ToString(),
                }
            };
        }
    }
}