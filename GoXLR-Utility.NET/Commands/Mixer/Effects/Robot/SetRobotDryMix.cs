using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotDryMix : CommandBase
    {
        public SetRobotDryMix(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotDryMix"] = new
                {
                    value
                }
            };
        }
    }
}