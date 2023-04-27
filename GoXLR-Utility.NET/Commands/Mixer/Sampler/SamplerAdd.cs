using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SamplerAdd : DeviceCommandBase
    {
        /// <summary>
        /// Add a Sample to a certain Sampler.
        /// </summary>
        /// <param name="bank">The Bank to edit</param>
        /// <param name="button">The Button to edit</param>
        /// <param name="fileName">The Audio file to add</param>
        public SamplerAdd(SamplerBank bank, BankButtonEnum button, string fileName)
        {
            Command = new Dictionary<string, object>
            {
                ["AddSample"] = new object[]
                {
                    bank.ToString(),
                    button.ToString(),
                    fileName
                }
            };
        }
    }
}