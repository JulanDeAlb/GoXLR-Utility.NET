using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorThreshold : CommandBase
    {
        public SetCompressorThreshold(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorThreshold"] = new
                {
                    value
                }
            };
        }
    }
}