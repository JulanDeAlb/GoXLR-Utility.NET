using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotPulseWidth : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Robot Pulse Width of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetRobotPulseWidth(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetRobotPulseWidth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotPulseWidth"] = value
            };
        }

        /// <summary>
        /// Set the Robot Pulse Width of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetRobotPulseWidth(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotPulseWidth), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotPulseWidth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotPulseWidth"] = value
            };
        }
    }
}