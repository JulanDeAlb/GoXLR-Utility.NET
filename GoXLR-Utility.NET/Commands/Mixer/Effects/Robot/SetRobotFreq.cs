using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotFreq : CommandBase
    {
        public SetRobotFreq(RobotRange range, int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotFreq"] = new
                {
                    range,
                    value
                }
            };
        }
    }
}