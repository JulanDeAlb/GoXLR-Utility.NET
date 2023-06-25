using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonOffStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Buttons Off Style.
        /// </summary>
        /// <param name="button">The Button to change</param>
        /// <param name="offStyle">The OffStyle to apply</param>
        public SetButtonOffStyle(ButtonLight button, LightingOffStyle offStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetButtonOffStyle"] = new object[]
                {
                    button.ToString(),
                    offStyle.ToString()
                }
            };
        }
    }
}