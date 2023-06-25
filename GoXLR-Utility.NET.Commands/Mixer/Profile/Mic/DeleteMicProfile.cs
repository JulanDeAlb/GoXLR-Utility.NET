using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class DeleteMicProfile : DeviceCommandBase
    {
        /// <summary>
        /// Delete a Mic Profile.
        /// </summary>
        /// <param name="name">The mic profile to delete</param>
        public DeleteMicProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["DeleteMicProfile"] = name
            };
        }
    }
}