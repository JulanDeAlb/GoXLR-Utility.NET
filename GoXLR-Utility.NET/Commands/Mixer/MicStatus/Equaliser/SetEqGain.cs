using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser
{
    public class SetEqGain : CommandBase
    {
        public SetEqGain(EqualiserEnum equaliser, int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEqGain"] = new
                {
                    equaliser,
                    value
                }
            };
        }
    }
}