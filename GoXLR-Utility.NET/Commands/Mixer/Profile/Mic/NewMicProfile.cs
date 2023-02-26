using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class NewMicProfile : DeviceCommandBase
    {
        /// <summary>
        /// Create a new Mic Profile.
        /// </summary>
        /// <param name="name">The mic profile name to create</param>
        public NewMicProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["NewMicProfile"] = new object[]
                {
                    name
                }
            };
        }
    }
}