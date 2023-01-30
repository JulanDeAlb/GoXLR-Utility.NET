using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStopPercent : CommandBase
    {
        public SetSampleStopPercent(SamplerBank bank, BankButtonEnum button, int index, double stopPct)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleStopPercent"] = new
                {
                    bank,
                    button,
                    index,
                    stopPct
                }
            };
        }
    }
}