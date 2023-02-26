using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class LoadProfileColours : DeviceCommandBase
    {
        /// <summary>
        /// Load a Profile's Colours.
        /// </summary>
        /// <param name="name">The Profile load the Colours from.</param>
        public LoadProfileColours(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadProfileColours"] = new object[]
                {
                    name
                }
            };
        }
    }
}