using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbModDepth: CommandBase
    {
        public SetReverbModDepth(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbModDepth"] = new
                {
                    value
                }
            };
        }
    }
}