using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Simple;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Simple
{
    public class SetSimpleColour : CommandBase
    {
        public SetSimpleColour(SimpleLightingEnum simple, string colour1, string colour2)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSimpleColour"] = new
                {
                    simple,
                    colour1,
                    colour2
                }
            };
        }
    }
}