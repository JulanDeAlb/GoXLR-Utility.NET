using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotThreshold : DeviceCommandBase
    {
        private const int MinValue = -36;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Robot Threshold of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-36 - 0)</param>
        public SetRobotThreshold(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetRobotThreshold), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetRobotThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotThreshold"] = value
            };
        }

        /// <summary>
        /// Set the Robot Threshold of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-36 - 0)</param>
        public SetRobotThreshold(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotThreshold), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotThreshold"] = value
            };
        }
    }
}