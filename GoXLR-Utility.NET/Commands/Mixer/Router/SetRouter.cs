using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Router
{
    public class SetRouter : CommandBase
    {
        public SetRouter(InputDevice input, OutputDevice output, bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetRouter"] = new
                {
                    input,
                    output,
                    isEnabled
                }
            };
        }
    }
}