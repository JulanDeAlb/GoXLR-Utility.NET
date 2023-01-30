using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorMakeupGain : CommandBase
    {
        public SetCompressorMakeupGain(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorMakeupGain"] = new
                {
                    value
                }
            };
        }
    }
}