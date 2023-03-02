using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonGroupColours : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button Groups Colour.
        /// </summary>
        /// <param name="buttonGroup">The Button Group to change Colour</param>
        /// <param name="colourOne">The Colour 1 (#ffffff)</param>
        /// <param name="colourTwo">The Colour 2 (#ffffff) (Optional)</param>
        public SetButtonGroupColours(ButtonGroupsEnum buttonGroup, string colourOne, string? colourTwo = null)
        {
            colourOne = colourOne.Replace("#", "");
            colourTwo = colourTwo?.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetButtonGroupColours"] = new object[]
                {
                    buttonGroup.ToString(),
                    colourOne,
                    colourTwo!
                }
            };
        }
    }
}