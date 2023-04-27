using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SamplerRemoveByIndex : DeviceCommandBase
    {
        /// <summary>
        /// Remove a Sample on a certain Index.
        /// </summary>
        /// <param name="bank">The Bank to edit</param>
        /// <param name="button">The Button to edit</param>
        /// <param name="index">The Index to remove</param>
        public SamplerRemoveByIndex(SamplerBank bank, BankButtonEnum button, int index)
        {
            Command = new Dictionary<string, object>
            {
                ["RemoveSampleByIndex"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    index
                }
            };
        }
    }
}