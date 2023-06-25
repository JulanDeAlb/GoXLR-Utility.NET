using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetFxEnabled : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button to a certain state.
        /// </summary>
        /// <param name="isEnabled">State of the Button</param>
        public SetFxEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFXEnabled"] = isEnabled
            };
        }
    }
}