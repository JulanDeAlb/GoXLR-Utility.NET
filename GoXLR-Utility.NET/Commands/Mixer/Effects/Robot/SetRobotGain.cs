using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotGain : CommandBase
    {
        public SetRobotGain(RobotRange range, int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotGain"] = new
                {
                    range,
                    value
                }
            };
        }
    }
}