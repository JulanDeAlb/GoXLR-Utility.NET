using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoAmount : CommandBase
    {
        public SetEchoAmount(int value)
        {
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