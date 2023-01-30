using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotStyle : CommandBase
    {
        public SetRobotStyle(RobotStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotStyle"] = new
                {
                    style
                }
            };
        }
    }
}