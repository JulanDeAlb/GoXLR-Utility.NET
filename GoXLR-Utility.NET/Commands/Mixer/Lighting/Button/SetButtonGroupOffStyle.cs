using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonGroupOffStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button Groups Off Style.
        /// </summary>
        /// <param name="buttonGroup">The Button Group to change</param>
        /// <param name="offStyle">The OffStyle to apply</param>
        public SetButtonGroupOffStyle(ButtonGroupsEnum buttonGroup, LightingOffStyleEnum offStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetButtonGroupOffStyle"] = new object[]
                {
                    buttonGroup.ToString(),
                    offStyle.ToString()
                }
            };
        }
    }
}