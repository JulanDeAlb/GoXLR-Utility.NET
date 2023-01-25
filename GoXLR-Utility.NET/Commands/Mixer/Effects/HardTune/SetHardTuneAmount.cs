using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneAmount : CommandBase
    {
        public SetHardTuneAmount(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneAmount"] = new
                {
                    value
                }
            };
        }
    }
}