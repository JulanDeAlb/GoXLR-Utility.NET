using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackRight : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Feedback Right of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetEchoFeedbackRight(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoFeedbackLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackRight"] = new object[]
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Echo Feedback Right of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetEchoFeedbackRight(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoFeedbackLeft), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoFeedbackLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackRight"] = new object[]
                {
                    value
                }
            };
        }
    }
}