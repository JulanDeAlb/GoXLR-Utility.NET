using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotPulseWidth : CommandBase
    {
        public SetRobotPulseWidth(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotPulseWidth"] = new
                {
                    value
                }
            };
        }
    }
}