using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Button;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Button
{
    public class SetButtonColours : CommandBase
    {
        public SetButtonColours(ButtonLightEnum button, string colour1, string colour2)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");
            Command = new Dictionary<string, object>
            {
                ["SetButtonColours"] = new
                {
                    button,
                    colour1,
                    colour2
                }
            };
        }
    }
}