using System.Collections.Generic;
using System.Globalization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStartPercent : DeviceCommandBase
    {
        public SetSampleStartPercent(SamplerBank bank, BankButtonEnum button, int index, double startPct)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleStartPercent"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    index,
                    startPct
                }
            };
        }
    }
}