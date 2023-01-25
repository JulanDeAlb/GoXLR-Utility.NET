using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Gender
{
    public class SetGenderAmount : CommandBase
    {
        public SetGenderAmount(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGenderAmount"] = new
                {
                    value
                }
            };
        }
    }
}