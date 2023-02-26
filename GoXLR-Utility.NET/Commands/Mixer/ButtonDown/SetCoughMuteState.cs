using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetCoughMuteState : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button to a certain state.
        /// </summary>
        /// <param name="muteState">State of the Button</param>
        public SetCoughMuteState(MuteState muteState)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCoughMuteState"] = new object[]
                {
                    muteState.ToString()
                }
            };
        }
    }
}