using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorAttack : CommandBase
    {
        public SetCompressorAttack(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorAttack"] = new
                {
                    value
                }
            };
        }
    }
}