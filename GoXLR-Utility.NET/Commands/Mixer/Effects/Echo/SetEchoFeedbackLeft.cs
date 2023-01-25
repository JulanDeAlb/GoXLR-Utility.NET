using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackLeft : CommandBase
    {
        public SetEchoFeedbackLeft(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackLeft"] = new
                {
                    value
                }
            };
        }
    }
}