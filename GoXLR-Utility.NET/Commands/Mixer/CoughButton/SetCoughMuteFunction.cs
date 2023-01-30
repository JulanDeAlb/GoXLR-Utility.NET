using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;

namespace GoXLR_Utility.NET.Commands.Mixer.CoughButton
{
    public class SetCoughMuteFunction : CommandBase
    {
        public SetCoughMuteFunction(MuteFunction function)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCoughMuteFunction"] = new
                {
                    function
                }
            };
        }
    }
}