using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Commands
{
    public class CommandBase
    {
        internal List<Dictionary<string, object>> CommandList;
        internal Dictionary<string, object> Command;
        public object Path;
        public object Object;
        public LogInfo LogInfo;

        public List<string> GetJson(long id, string serialNumber = null)
        {
            var returnStrings = new List<string>();

            if (Command != null && serialNumber != null)
            {
                Object = new
                {
                    Command = new object[]
                    {
                        serialNumber,
                        Command
                    }
                };
            } else if (CommandList != null && serialNumber != null)
            {
                foreach (var command in CommandList)
                {
                    var dataObject = new
                    {
                        Command = new object[]
                        {
                            serialNumber,
                            command
                        }
                    };

                    returnStrings.Add(JsonSerializer.Serialize(new
                    {
                        id,
                        data = (object) dataObject
                    }));
                }
            } else if (Path != null)
            {
                Object = new
                {
                    OpenPath = Path
                };
            } else if (Command != null && serialNumber == null)
            {
                Object = new
                {
                    Daemon = Command
                };
            }

            if (Object == null && returnStrings.Count == 0)
                return null;

            if (Object != null)
            {
                returnStrings.Add(JsonSerializer.Serialize(new
                {
                    id,
                    data = Object
                }));
            }

            return returnStrings;
        }

        internal int SetMinValue(string cmdName, int value)
        {
            LogInfo = new LogInfo(LogLevel.Debug, new EventId(5, "Commands"), true, cmdName, value.ToString());
            return value;
        }

        internal int SetMaxValue(string cmdName, int value)
        {
            LogInfo = new LogInfo(LogLevel.Debug, new EventId(5, "Commands"), false, cmdName, value.ToString());
            return value;
        }
    }
}