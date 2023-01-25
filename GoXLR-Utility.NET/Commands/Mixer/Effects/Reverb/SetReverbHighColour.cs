using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbHighColour : CommandBase
    {
        public SetReverbHighColour(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbHighColour"] = new
                {
                    value
                }
            };
        }
    }
}