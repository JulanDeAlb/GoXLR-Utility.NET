using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbEarlyLevel : CommandBase
    {
        public SetReverbEarlyLevel(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbEarlyLevel"] = new
                {
                    value
                }
            };
        }
    }
}