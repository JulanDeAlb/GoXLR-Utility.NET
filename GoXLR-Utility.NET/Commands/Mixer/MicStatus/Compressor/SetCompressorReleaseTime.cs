using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorReleaseTime : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 19;

        /// <summary>
        /// Set the Compressor Release timing.
        /// </summary>
        /// <param name="timing">The timing to apply</param>
        public SetCompressorReleaseTime(CompReleaseTime timing)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorReleaseTime"] = timing
            };
        }

        /// <summary>
        /// Set the Compressor Release timing.
        /// </summary>
        /// <param name="timing">The timing to apply as Byte (0 - 19)</param>
        public SetCompressorReleaseTime(byte timing)
        {
            timing = timing > MaxValue ? (byte) SetMaxValue(nameof(SetCompressorReleaseTime), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorReleaseTime"] = timing
            };
        }

        /// <summary>
        /// Set the Compressor Release timing.
        /// </summary>
        /// <param name="timing">The timing to apply as Int (0-19)</param>
        public SetCompressorReleaseTime(int timing)
        {
            timing = timing < MinValue ? SetMinValue(nameof(SetCompressorReleaseTime), MinValue) : timing;
            timing = timing > MaxValue ? SetMaxValue(nameof(SetCompressorReleaseTime), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorReleaseTime"] = timing
            };
        }
    }
}