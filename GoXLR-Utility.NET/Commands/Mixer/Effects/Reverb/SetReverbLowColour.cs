using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbLowColour : CommandBase
    {
        public SetReverbLowColour(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbLowColour"] = new
                {
                    value
                }
            };
        }
    }
}