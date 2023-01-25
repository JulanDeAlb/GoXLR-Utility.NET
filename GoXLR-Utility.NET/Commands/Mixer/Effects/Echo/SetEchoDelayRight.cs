using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoDelayRight : CommandBase
    {
        public SetEchoDelayRight(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoDelayRight"] = new
                {
                    value
                }
            };
        }
    }
}