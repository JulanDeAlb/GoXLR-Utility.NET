using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SamplerPlayByIndex : DeviceCommandBase
    {
        /// <summary>
        /// Play a Sample on a certain Index.
        /// </summary>
        /// <param name="bank">The Bank where the Sample is</param>
        /// <param name="button">The Button where the Sample is</param>
        /// <param name="index">The Index to play</param>
        public SamplerPlayByIndex(SamplerBank bank, BankButtonEnum button, int index)
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