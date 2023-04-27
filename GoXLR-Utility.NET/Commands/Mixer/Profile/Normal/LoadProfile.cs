using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class LoadProfile : DeviceCommandBase
    {
        /// <summary>
        /// Load a Profile.
        /// </summary>
        /// <param name="name">The profile to load</param>
        public LoadProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadProfile"] = name
            };
        }
    }
}