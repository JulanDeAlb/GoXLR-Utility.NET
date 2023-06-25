using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting
{
    public class SetGlobalColour : DeviceCommandBase
    {
        /// <summary>
        /// Set the Global Colour.
        /// </summary>
        /// <param name="colour">The Colour (#ffffff)</param>
        public SetGlobalColour(string colour)
        {
            colour = colour.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetGlobalColour"] = colour
            };
        }
    }
}