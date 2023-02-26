using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSamplerOrder : DeviceCommandBase
    {
        public SetSamplerOrder(SamplerBank bank, BankButtonEnum button, SamplePlayOrder order)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSamplerOrder"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    order.ToString()
                }
            };
        }
    }
}