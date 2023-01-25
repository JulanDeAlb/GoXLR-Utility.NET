using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchAmount : CommandBase
    {
        public SetPitchAmount(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetPitchAmount"] = new
                {
                    value
                }
            };
        }
    }
}