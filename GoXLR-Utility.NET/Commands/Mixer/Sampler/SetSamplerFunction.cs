using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSamplerFunction : CommandBase
    {
        public SetSamplerFunction(SamplerBank bank, BankButtonEnum button, SamplePlaybackMode mode)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSamplerFunction"] = new
                {
                    bank,
                    button,
                    mode
                }
            };
        }
    }
}