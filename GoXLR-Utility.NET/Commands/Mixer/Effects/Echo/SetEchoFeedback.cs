using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedback : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Feedback of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetEchoFeedback(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoFeedback), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedback"] = new object[]
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Echo Feedback of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetEchoFeedback(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoFeedback), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoFeedback), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedback"] = new object[]
                {
                    value
                }
            };
        }
    }
}