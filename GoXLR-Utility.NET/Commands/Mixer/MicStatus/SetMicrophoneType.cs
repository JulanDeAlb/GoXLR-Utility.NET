using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus
{
    public class SetMicrophoneType : DeviceCommandBase
    {
        /// <summary>
        /// Set the Microphone Type
        /// </summary>
        /// <param name="type">The type to be used</param>
        public SetMicrophoneType(MicrophoneType type)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMicrophoneType"] = new object[]
                {
                    type.ToString()
                }
            };
        }
    }
}