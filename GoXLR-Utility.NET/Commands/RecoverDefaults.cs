using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands
{
    public class RecoverDefaults : NormalCommandBase
    {
        /// <summary>
        /// Recover defaults like default Profiles etc.
        /// </summary>
        /// <param name="path">The type to recover the defaults</param>
        public RecoverDefaults(Defaults path)
        {
            Command = new Dictionary<string, object>
            {
                ["RecoverDefaults"] = path.ToString()
            };
        }
    }
}