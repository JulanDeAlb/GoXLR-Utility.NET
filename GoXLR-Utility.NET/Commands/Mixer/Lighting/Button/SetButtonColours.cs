using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonColours : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button's Colour
        /// </summary>
        /// <param name="button">The Button to change Colour</param>
        /// <param name="colour1">The Colour 1 (#ffffff)</param>
        /// <param name="colour2">The Colour 2 (#ffffff)</param>
        public SetButtonColours(ButtonLightEnum button, string colour1, string colour2)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetButtonColours"] = new object[]
                {
                    button.ToString(),
                    colour1,
                    colour2
                }
            };
        }
    }
}