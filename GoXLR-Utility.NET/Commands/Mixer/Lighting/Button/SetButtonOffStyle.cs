using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonOffStyle : CommandBase
    {
        public SetButtonOffStyle(ButtonLightEnum button, LightingOffStyleEnum offStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetButtonOffStyle"] = new
                {
                    button,
                    offStyle
                }
            };
        }
    }
}