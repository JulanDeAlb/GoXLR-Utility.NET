using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSampleStartPercent : DeviceCommandBase
    {
        /// <summary>
        /// Set the Start Percentage of a certain Sample.
        /// </summary>
        /// <param name="bank">The Bank to edit</param>
        /// <param name="button">The Button to edit</param>
        /// <param name="index">The Sampleindex to edit</param>
        /// <param name="startPct">The Start Percentage to apply</param>
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