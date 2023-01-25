using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoTempo : CommandBase
    {
        public SetEchoTempo(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoTempo"] = new
                {
                    value
                }
            };
        }
    }
}