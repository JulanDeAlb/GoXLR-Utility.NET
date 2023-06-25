using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class DeleteProfile : DeviceCommandBase
    {
        /// <summary>
        /// Delete a Profile.
        /// </summary>
        /// <param name="name">The Profile to delete</param>
        public DeleteProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["DeleteProfile"] = name
            };
        }
    }
}