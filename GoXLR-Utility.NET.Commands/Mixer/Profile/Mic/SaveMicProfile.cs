using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class SaveMicProfile : DeviceCommandBase
    {
        /// <summary>
        /// Save the Mic Profile.
        /// </summary>
        public SaveMicProfile()
        {
            Command = new Dictionary<string, object>
            {
                ["SaveMicProfile"] = new object[] {}
            };
        }
    }
}