using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetFaderMuteState : DeviceCommandBase
    {
        /// <summary>
        /// Set the Button to a certain state.
        /// </summary>
        /// <param name="faderName">Fader that should be changed</param>
        /// <param name="muteState">State of the Button</param>
        public SetFaderMuteState(FaderName faderName, MuteState muteState)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderMuteState"] = new object[]
                {
                    faderName.ToString(),
                    muteState.ToString()
                }
            };
        }
    }
}