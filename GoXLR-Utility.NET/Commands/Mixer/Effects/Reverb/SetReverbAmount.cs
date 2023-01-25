using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbAmount : CommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;
        
        public SetReverbAmount(int value)
        {
            value = value < MinValue ? MinValue : value;
            value = value > MaxValue ? MaxValue : value;
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