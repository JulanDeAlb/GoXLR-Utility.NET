using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Gender
{
    public class SetGenderAmount : CommandBase
    {
        private const int MinValue = -12;
        private const int MaxValue = 12;
        
        public SetGenderAmount(int value)
        {
            value = value < MinValue ? MinValue : value;
            value = value > MaxValue ? MaxValue : value;
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