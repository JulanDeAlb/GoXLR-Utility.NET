using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbDiffuse : CommandBase
    {
        public SetReverbDiffuse(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbDiffuse"] = new
                {
                    value
                }
            };
        }
    }
}