using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus
{
    public class SetMicrophoneType : CommandBase
    {
        public SetMicrophoneType(MicrophoneType type)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMicrophoneType"] = new
                {
                    type
                }
            };
        }
    }
}