using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbDecay : CommandBase
    {
        public SetReverbDecay(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbDecay"] = new
                {
                    value
                }
            };
        }
    }
}