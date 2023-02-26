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
        /// <param name="colour2">The Colour 2 (#ffffff)</param>
        public SetSimpleColour(SimpleLightingEnum simple, string colour1, string colour2)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetSimpleColour"] = new object[]
                {
                    simple.ToString(),
                    colour1,
                    colour2
                }
            };
        }
    }
}