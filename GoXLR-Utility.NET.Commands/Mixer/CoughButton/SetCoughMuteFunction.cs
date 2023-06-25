using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.Commands.Mixer.CoughButton
{
    public class SetCoughMuteFunction : DeviceCommandBase
    {
        /// <summary>
        /// Set the Mute behavior of the Cough Button.
        /// </summary>
        /// <param name="muteFunction">Mute behavior of the Button</param>
        public SetCoughMuteFunction(MuteFunction muteFunction)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCoughMuteFunction"] = muteFunction.ToString()
            };
        }
    }
}