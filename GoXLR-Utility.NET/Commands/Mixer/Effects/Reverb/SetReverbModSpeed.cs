using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbModSpeed : CommandBase
    {
        public SetReverbModSpeed(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbModSpeed"] = new
                {
                    value
                }
            };
        }
    }
}