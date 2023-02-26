using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetActiveSamplerBank : DeviceCommandBase
    {
        /// <summary>
        /// Set the Active Sampler Bank (Button A-C).
        /// </summary>
        /// <param name="samplerBank">Sampler Bank which should be active</param>
        public SetActiveSamplerBank(SamplerBank samplerBank)
        {
            Command = new Dictionary<string, object>
            {
                ["SetActiveSamplerBank"] = new object[]
                {
                    samplerBank.ToString()
                }
            };
        }
    }
}