using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Sampler
{
    public class SetSampleOffStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Samplers Off Style.
        /// </summary>
        /// <param name="button">The Sampler to edit</param>
        /// <param name="offStyle">The OffStyle to apply</param>
        public SetSampleOffStyle(SamplerEnum button, LightingOffStyleEnum offStyle)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleOffStyle"] = new object[]
                {
                    button.ToString(),
                    offStyle.ToString()
                }
            };
        }
    }
}