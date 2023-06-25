using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class LoadMicProfile : DeviceCommandBase
    {
        /// <summary>
        /// Load a Mic Profile.
        /// </summary>
        /// <param name="name">The mic profile to load</param>
        /// <param name="persist">Whether to stay loaded after device startup</param>
        public LoadMicProfile(string name, bool persist)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadMicProfile"] = new object[]
                {
                    name,
                    persist
                }
            };
        }
    }
}