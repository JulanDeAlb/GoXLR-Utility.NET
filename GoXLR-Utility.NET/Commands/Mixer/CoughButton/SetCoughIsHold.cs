using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.CoughButton
{
    public class SetCoughIsHold : DeviceCommandBase
    {
        /// <summary>
        /// Set whether the CoughButton has to be pressed or can be toggled.
        /// </summary>
        /// <param name="isHold">True if it needs to be pressed</param>
        public SetCoughIsHold(bool isHold)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCoughIsHold"] = new object[]
                {
                    isHold
                }
            };
        }
    }
}