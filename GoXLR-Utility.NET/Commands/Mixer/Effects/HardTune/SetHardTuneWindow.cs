using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneWindow : CommandBase
    {
        public SetHardTuneWindow(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneWindow"] = new
                {
                    value
                }
            };
        }
    }
}