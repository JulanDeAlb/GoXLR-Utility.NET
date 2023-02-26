using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Sampler
{
    public class SetSampleColour : DeviceCommandBase
    {
        /// <summary>
        /// Set the Sampler Colours.
        /// </summary>
        /// <param name="sampler">The Sampler to edit</param>
        /// <param name="colour1">The Colour 1 (#ffffff)</param>
        /// <param name="colour2">The Colour 2 (#ffffff)</param>
        /// <param name="colour3">The Colour 3 (#ffffff)</param>
        public SetSampleColour(SamplerEnum sampler, string colour1, string colour2, string colour3)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");
            colour3 = colour3.Replace("#", "");

            Command = new Dictionary<string, object>
            {
                ["SetSampleColour"] = new object[]
                {
                    sampler.ToString(),
                    colour1,
                    colour2,
                    colour3
                }
            };
        }
    }
}