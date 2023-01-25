using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbTailLevel : CommandBase
    {
        public SetReverbTailLevel(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbTailLevel"] = new
                {
                    value
                }
            };
        }
    }
}