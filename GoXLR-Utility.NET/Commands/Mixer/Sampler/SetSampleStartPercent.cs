using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStartPercent : CommandBase
    {
        public SetSampleStartPercent(SamplerBank bank, BankButtonEnum button, int index, double startPct)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleStartPercent"] = new
                {
                    bank,
                    button,
                    index,
                    startPct
                }
            };
        }
    }
}