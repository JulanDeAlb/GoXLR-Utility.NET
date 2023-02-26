using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class PlaySampleByIndex : DeviceCommandBase
    {
        public PlaySampleByIndex(SamplerBank bank, BankButtonEnum button, int index)
        {
            Command = new Dictionary<string, object>
            {
                ["PlaySampleByIndex"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    index
                }
            };
        }
    }
}