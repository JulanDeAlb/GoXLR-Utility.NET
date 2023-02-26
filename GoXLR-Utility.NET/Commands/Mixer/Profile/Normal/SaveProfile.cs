using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Profile.Normal
{
    public class SaveProfile : DeviceCommandBase
    {
        /// <summary>
        /// Save the Profile.
        /// </summary>
        public SaveProfile()
        {
            Command = new Dictionary<string, object>
            {
                ["SaveProfile"] = new object[] { }
            };
        }
    }
}