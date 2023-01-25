using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorRatio : CommandBase
    {
        public SetCompressorRatio(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorRatio"] = new
                {
                    value
                }
            };
        }
    }
}