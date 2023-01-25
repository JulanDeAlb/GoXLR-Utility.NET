using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoAmount : CommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;
        
        public SetEchoAmount(int value)
        {
            value = value < MinValue ? MinValue : value;
            value = value > MaxValue ? MaxValue : value;
            Command = new Dictionary<string, object>
            {
                ["SetEchoAmount"] = new
                {
                    value
                }
            };
        }
    }
}