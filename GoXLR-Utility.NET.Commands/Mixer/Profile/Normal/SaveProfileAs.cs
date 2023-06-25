using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class SaveProfileAs : DeviceCommandBase
    {
        /// <summary>
        /// Save the Profile as... .
        /// </summary>
        /// <param name="name">The Name to save the Profile</param>
        public SaveProfileAs(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["SaveProfileAs"] = name
            };
        }
    }
}