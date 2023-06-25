using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.FaderStatus
{
    public class SetFaderMuteFunction : DeviceCommandBase
    {
        /// <summary>
        /// Set a MuteFunction of a certain Fader
        /// </summary>
        /// <param name="fader">Fader to edit</param>
        /// <param name="function">MuteFunction to set</param>
        public SetFaderMuteFunction(FaderName fader, MuteFunction function)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFaderMuteFunction"] = new object[]
                {
                    fader.ToString(),
                    function.ToString()
                }
            };
        }
    }
}