using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackXfbRtoL : CommandBase
    {
        public SetEchoFeedbackXfbRtoL(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBRtoL"] = new
                {
                    value
                }
            };
        }
    }
}