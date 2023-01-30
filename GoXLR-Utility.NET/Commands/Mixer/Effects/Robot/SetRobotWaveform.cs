using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotWaveform : CommandBase
    {
        public SetRobotWaveform(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotWaveform"] = new
                {
                    value
                }
            };
        }
    }
}