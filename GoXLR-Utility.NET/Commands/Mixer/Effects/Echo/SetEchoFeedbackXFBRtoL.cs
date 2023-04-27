using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackXfbRtoL : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Feedback XFB R to L of the current Preset.
        /// </summary>
        /// <param name="value">The value as Byte (0 - 100)</param>
        public SetEchoFeedbackXfbRtoL(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoFeedbackXfbRtoL), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBRtoL"] = value
            };
        }

        /// <summary>
        /// Set the Echo Feedback XFB R to L of the current Preset.
        /// </summary>
        /// <param name="value">The value as Int (0 - 100)</param>
        public SetEchoFeedbackXfbRtoL(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoFeedbackXfbRtoL), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoFeedbackXfbRtoL), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBRtoL"] = value
            };
        }
    }
}