using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Simple
{
    public class SetSimpleColour : DeviceCommandBase
    {
        /// <summary>
        /// Set the Simple Colours<br/>
        /// Like Accent, Scribble1, Scribble2, Scribble3, Scribble4, Global
        /// </summary>
        /// <param name="simple">The Simple one to change</param>
        /// <param name="colour1">The Colour 1 (#ffffff)</param>
        public SetSimpleColour(SimpleLighting simple, string colour1)
        {
            colour1 = colour1.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetSimpleColour"] = new object[]
                {
                    simple.ToString(),
                    colour1
                }
            };
        }
    }
}