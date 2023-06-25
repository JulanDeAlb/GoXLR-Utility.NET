using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSamplerFunction : DeviceCommandBase
    {
        /// <summary>
        /// Set a Function of a certain Sampler.
        /// </summary>
        /// <param name="bank">The Bank to edit</param>
        /// <param name="button">The Button to edit</param>
        /// <param name="mode">The Mode to apply</param>
        public SetSamplerFunction(SamplerBank bank, BankButtonEnum button, SamplePlaybackMode mode)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSamplerFunction"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    mode.ToString()
                }
            };
        }
    }
}