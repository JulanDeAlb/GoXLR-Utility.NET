using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Robot Style of the current Preset.
        /// </summary>
        /// <param name="style">The Style to apply</param>
        public SetRobotStyle(RobotStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotStyle"] = new object[]
                {
                    style.ToString()
                }
            };
        }
    }
}