using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneRate : CommandBase
    {
        public SetHardTuneRate(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneRate"] = new
                {
                    value
                }
            };
        }
    }
}