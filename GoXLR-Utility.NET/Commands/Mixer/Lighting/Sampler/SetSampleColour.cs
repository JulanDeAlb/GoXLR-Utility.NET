using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Sampler;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Sampler
{
    public class SetSampleColour : CommandBase
    {
        public SetSampleColour(SamplerEnum sampler, string colour1, string colour2, string colour3)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSampleColour"] = new
                {
                    sampler,
                    colour1,
                    colour2,
                    colour3
                }
            };
        }
    }
}