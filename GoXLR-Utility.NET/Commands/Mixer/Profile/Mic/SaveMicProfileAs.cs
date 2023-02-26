using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Mic
{
    public class SaveMicProfileAs : DeviceCommandBase
    {
        /// <summary>
        /// Save the Mic Profile as... .
        /// </summary>
        /// <param name="name">The Name to save the Mic Profile</param>
        public SaveMicProfileAs(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["SaveMicProfileAs"] = new object[]
                {
                    name
                }
            };
        }
    }
}