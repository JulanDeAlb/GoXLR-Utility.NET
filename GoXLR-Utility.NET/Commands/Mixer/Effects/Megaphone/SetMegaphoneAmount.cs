using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone
{
    public class SetMegaphoneAmount : CommandBase
    {
        public SetMegaphoneAmount(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneAmount"] = new
                {
                    value
                }
            };
        }
    }
}