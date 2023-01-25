using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetRobotEnabled : CommandBase
    {
        public SetRobotEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRobotEnabled"] = new
                {
                    isEnabled
                }
            };
        }
    }
}