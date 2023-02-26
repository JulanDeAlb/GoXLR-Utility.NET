using System;
using System.Collections.Generic;
using System.Text.Json;

namespace GoXLR_Utility.NET.Commands
{
    public class CommandBase
    {
        internal List<Dictionary<string, object>> CommandList;
        internal Dictionary<string, object> Command;
        internal object Path;
        internal object Object;

        internal List<string> GetJson(long id, string serialNumber = null)
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
            }

            if (Object is null && returnStrings.Count == 0)
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
            Console.WriteLine("{cmdName} exceeds min. Value: {minValue}", cmdName, value.ToString());
            return value;
        }

        internal static int SetMaxValue(string cmdName, int value)
        {
            Console.WriteLine("{cmdName} exceeds max. Value: {maxValue}", cmdName, value.ToString());
            return value;
        }
    }
}