using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace GoXLR_Utility.NET.Commands
{
    public class CommandBase
    {
        internal Dictionary<string, object> Command;
        internal object Path;
        internal object Object;

        internal string GetJson(long id, string serialNumber = null)
        {
            if (Command != null && serialNumber != null)
            {
                Object = new
                {
                    Command = new IEnumerable[]
                    {
                        serialNumber,
                        Command
                    }
                };
            } else if (Path != null)
            {
                Object = new
                {
                    OpenPath = Path
                };
            }

            if (Object is null)
                return null;
            
            var finalCommand = new
            {
                id,
                data = Object
            };

            return JsonSerializer.Serialize(finalCommand);
        }
        
        //Command = new Dictionary<string, object>
        //{
        //    ["SetFader"] = new
        //    {
        //        
        //    }
        //};
    }
}