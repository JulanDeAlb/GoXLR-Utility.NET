using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Commands.Mixer.Settings.Display
{
    public class SetDisplayMode : DeviceCommandBase
    {
        /// <summary>
        /// Set the Display Mode of a Component in Mic Settings.
        /// </summary>
        /// <param name="displayComponent">The Component</param>
        /// <param name="mode">The Mode</param>
        public SetDisplayMode(DisplayComponent displayComponent, DisplayMode mode)
        {
            Command = new Dictionary<string, object>
            {
                ["SetElementDisplayMode"] = new object[]
                {
                    displayComponent.ToString(),
                    mode.ToString()
                }
            };
        }
    }
}