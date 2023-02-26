using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoFeedbackXfbLtoR : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Feedback XFB L to R of the current Preset.
        /// </summary>
        /// <param name="value">The value as Byte (0 - 100)</param>
        public SetEchoFeedbackXfbLtoR(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoFeedbackXfbLtoR), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBLtoR"] = new object[]
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Echo Feedback XFB L to R of the current Preset.
        /// </summary>
        /// <param name="value">The value as Int (0 - 100)</param>
        public SetEchoFeedbackXfbLtoR(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoFeedbackXfbLtoR), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoFeedbackXfbLtoR), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoFeedbackXFBLtoR"] = new object[]
                {
                    value
                }
            };
        }
    }
}