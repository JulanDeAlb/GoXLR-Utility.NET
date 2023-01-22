using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus
{
    public class SetMicrophoneGain : CommandBase
    {
        public SetMicrophoneGain(MicrophoneType type, byte gain)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMicrophoneGain"] = new
                {
                    type,
                    gain
                }
            };
        }
    }
}