using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetHardTuneEnabled : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button to a certain state.
        /// </summary>
        /// <param name="isEnabled">State of the Button</param>
        public SetHardTuneEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneEnabled"] = isEnabled
            };
        }
    }
}