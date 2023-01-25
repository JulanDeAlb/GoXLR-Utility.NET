using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedback : CommandBase
    {
        public SetEchoFeedback(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedback"] = new
                {
                    value
                }
            };
        }
    }
}