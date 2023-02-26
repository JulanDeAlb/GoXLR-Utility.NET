using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class NewProfile : DeviceCommandBase
    {
        /// <summary>
        /// Create a new Profile.
        /// </summary>
        /// <param name="name">The profile name to create</param>
        public NewProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["NewProfile"] = new object[]
                {
                    name
                }
            };
        }
    }
}