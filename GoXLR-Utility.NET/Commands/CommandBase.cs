using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Commands
{
    public class CommandBase
    {
        internal List<Dictionary<string, object>>? CommandList;
        internal Dictionary<string, object>? Command;
        internal object? Path;
        internal object? Object;

        internal List<string>? GetJson(long id, string? serialNumber = null)
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
                Object = Command;
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

        internal static int SetMinValue(string cmdName, int value)
        {
            Utility.Logger?.Log(LogLevel.Debug, new EventId(5, "Commands"), "{cmdName} exceeds min. Value: {minValue}", cmdName, value.ToString());
            return value;
        }

        internal static int SetMaxValue(string cmdName, int value)
        {
            Utility.Logger?.Log(LogLevel.Debug, new EventId(5, "Commands"), "{cmdName} exceeds max. Value: {maxValue}", cmdName, value.ToString());
            return value;
        }
    }
}