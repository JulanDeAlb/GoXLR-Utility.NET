using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class LoadMicProfile : DeviceCommandBase
    {
        /// <summary>
        /// Load a Mic Profile.
        /// </summary>
        /// <param name="name">The mic profile to load</param>
        public LoadMicProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadMicProfile"] = name
            };
        }
    }
}