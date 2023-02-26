using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorMakeupGain : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 24;

        /// <summary>
        /// Set the Compressor Makeup Gain.
        /// </summary>
        /// <param name="value">The value as Byte (0 - 24)</param>
        public SetCompressorMakeupGain(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetCompressorMakeupGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorMakeupGain"] = new object[]
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Compressor Makeup Gain.
        /// </summary>
        /// <param name="value">The value as Int (0 - 24)</param>
        public SetCompressorMakeupGain(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetCompressorMakeupGain), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetCompressorMakeupGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorMakeupGain"] = new object[]
                {
                    value
                }
            };
        }
    }
}