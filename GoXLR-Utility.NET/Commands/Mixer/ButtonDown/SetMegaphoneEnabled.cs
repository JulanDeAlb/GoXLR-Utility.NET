using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetMegaphoneEnabled : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button to a certain state.
        /// </summary>
        /// <param name="isEnabled">State of the Button</param>
        public SetMegaphoneEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneEnabled"] = new object[]
                {
                    isEnabled
                }
            };
        }
    }
}