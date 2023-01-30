using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbHighFactor : CommandBase
    {
        public SetReverbHighFactor(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbHighFactor"] = new
                {
                    value
                }
            };
        }
    }
}