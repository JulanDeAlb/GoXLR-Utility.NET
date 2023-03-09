using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Commands.Mixer.Settings.Display
{
    public class SetElementDisplayMode : DeviceCommandBase
    {
        /// <summary>
        /// Set the Display Mode of a Component in Mic Settings.
        /// </summary>
        /// <param name="displayComponent">The Component</param>
        /// <param name="mode">The Mode</param>
        public SetElementDisplayMode(DisplayComponent displayComponent, DisplayMode mode)
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