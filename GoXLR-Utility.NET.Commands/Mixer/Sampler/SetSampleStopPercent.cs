using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStopPercent : DeviceCommandBase
    {
        /// <summary>
        /// Set the Stop Percentage of a certain Sample.
        /// </summary>
        /// <param name="bank">The Bank to edit</param>
        /// <param name="button">The Button to edit</param>
        /// <param name="index">The Sampleindex to edit</param>
        /// <param name="stopPct">The Stop Percentage to apply</param>
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