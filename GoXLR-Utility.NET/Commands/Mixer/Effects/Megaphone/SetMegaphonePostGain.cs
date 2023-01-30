using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone
{
    public class SetMegaphonePostGain : CommandBase
    {
        public SetMegaphonePostGain(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMegaphonePostGain"] = new
                {
                    value
                }
            };
        }
    }
}