using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Commands.Mixer.Settings.Display
{
    public class SetElementDisplayMode : CommandBase
    {
        public SetElementDisplayMode(DisplayEnum display, DisplayModeEnum mode)
        {
            Command = new Dictionary<string, object>
            {
                ["SetElementDisplayMode"] = new
                {
                    display,
                    mode
                }
            };
        }
    }
}