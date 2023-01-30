using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchAmount : CommandBase
    {
        private const int MinValue = -24;
        private const int MaxValue = 24;
        
        public SetPitchAmount(int value)
        {
            value = value < MinValue ? MinValue : value;
            value = value > MaxValue ? MaxValue : value;
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