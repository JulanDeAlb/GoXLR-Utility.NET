using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class LoadProfile : DeviceCommandBase
    {
        /// <summary>
        /// Load a Profile.
        /// </summary>
        /// <param name="name">The profile to load</param>
        /// /// <param name="persist">Whether to stay loaded after device startup</param>
        public LoadProfile(string name, bool persist)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadProfile"] = new object[]
                {
                    name,
                    persist
                }
            };
        }
    }
}