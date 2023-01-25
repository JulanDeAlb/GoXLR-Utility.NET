using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbAmount : CommandBase
    {
        public SetReverbAmount(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbAmount"] = new
                {
                    value
                }
            };
        }
    }
}