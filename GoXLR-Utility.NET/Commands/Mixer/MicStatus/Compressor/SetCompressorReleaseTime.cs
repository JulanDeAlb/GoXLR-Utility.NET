using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorReleaseTime : CommandBase
    {
        public SetCompressorReleaseTime(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorReleaseTime"] = new
                {
                    value
                }
            };
        }
    }
}