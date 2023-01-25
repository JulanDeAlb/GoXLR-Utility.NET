using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoDelayLeft : CommandBase
    {
        public SetEchoDelayLeft(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoDelayLeft"] = new
                {
                    value
                }
            };
        }
    }
}