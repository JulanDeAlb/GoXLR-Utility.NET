using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorThreshold : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = -40;

        /// <summary>
        /// Set the Compressor Threshold.
        /// </summary>
        /// <param name="value">The value as sByte (-40 - 0)</param>
        public SetCompressorThreshold(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetCompressorThreshold), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetCompressorThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorThreshold"] = new object[]
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Compressor Threshold.
        /// </summary>
        /// <param name="value">The value as Int (-40 - 0)</param>
        public SetCompressorThreshold(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetCompressorThreshold), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetCompressorThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorThreshold"] = new object[]
                {
                    value
                }
            };
        }
    }
}