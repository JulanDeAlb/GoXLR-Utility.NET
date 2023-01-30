using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbPreDelay : CommandBase
    {
        public SetReverbPreDelay(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbPreDelay"] = new
                {
                    value
                }
            };
        }
    }
}