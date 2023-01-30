using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotThreshold : CommandBase
    {
        public SetRobotThreshold(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotThreshold"] = new
                {
                    value
                }
            };
        }
    }
}