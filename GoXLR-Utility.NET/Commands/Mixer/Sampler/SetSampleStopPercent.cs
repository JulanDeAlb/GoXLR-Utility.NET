using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStopPercent : DeviceCommandBase
    {
        public SetSampleStopPercent(SamplerBank bank, BankButtonEnum button, int index, double stopPct)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleStopPercent"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    index,
                    stopPct
                }
            };
        }
    }
}