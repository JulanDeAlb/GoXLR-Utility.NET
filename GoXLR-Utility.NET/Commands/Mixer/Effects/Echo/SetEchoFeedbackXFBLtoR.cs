using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackXfbLtoR : CommandBase
    {
        public SetEchoFeedbackXfbLtoR(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBLtoR"] = new
                {
                    value
                }
            };
        }
    }
}