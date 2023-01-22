using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus
{
    public class SetGateThreshold : CommandBase
    {
        public SetGateThreshold(byte threshold)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateThreshold"] = new
                {
                    threshold
                }
            };
        }
    }
}