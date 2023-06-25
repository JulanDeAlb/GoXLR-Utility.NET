using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorRatio : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 14;

        /// <summary>
        /// Set the Compressor Ratio.
        /// </summary>
        /// <param name="ratio">The Ratio to apply</param>
        public SetCompressorRatio(CompRatio ratio)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorRatio"] = ratio
            };
        }

        /// <summary>
        /// Set the Compressor Ratio.
        /// </summary>
        /// <param name="ratio">The Ratio as Byte (0 - 14)</param>
        public SetCompressorRatio(byte ratio)
        {
            ratio = ratio > MaxValue ? (byte) SetMaxValue(nameof(SetCompressorRatio), MaxValue) : ratio;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorRatio"] = ratio
            };
        }

        /// <summary>
        /// Set the Compressor Ratio.
        /// </summary>
        /// <param name="ratio">The Ratio as Int (0-14)</param>
        public SetCompressorRatio(int ratio)
        {
            ratio = ratio < MinValue ? SetMinValue(nameof(SetCompressorRatio), MinValue) : ratio;
            ratio = ratio > MaxValue ? SetMaxValue(nameof(SetCompressorRatio), MaxValue) : ratio;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorRatio"] = ratio
            };
        }
    }
}