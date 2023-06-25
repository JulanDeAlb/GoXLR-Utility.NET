using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackLeft : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Feedback Left of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetEchoFeedbackLeft(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoFeedbackLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackLeft"] = value
            };
        }

        /// <summary>
        /// Set the Echo Feedback Left of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetEchoFeedbackLeft(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoFeedbackLeft), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoFeedbackLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackLeft"] = value
            };
        }
    }
}