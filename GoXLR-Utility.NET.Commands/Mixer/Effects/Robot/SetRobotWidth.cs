using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotWidth : DeviceCommandBase
    {
        private const int MinValue = -12;
        private const int MaxValue = 12;

        /// <summary>
        /// Set the Robot Width of the current Preset.
        /// </summary>
        /// <param name="range">The Range to edit</param>
        /// <param name="value">Value as sByte (-12 - 12)</param>
        public SetRobotWidth(RobotRange range, sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetRobotWidth), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetRobotWidth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotWidth"] = new object[]
                {
                    range.ToString(),
                    value
                }
            };
        }

        /// <summary>
        /// Set the Robot Width of the current Preset.
        /// </summary>
        /// <param name="range">The Range to edit</param>
        /// <param name="value">Value as Int (-12 - 12)</param>
        public SetRobotWidth(RobotRange range, int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotWidth), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotWidth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotWidth"] = new object[]
                {
                    range.ToString(),
                    value
                }
            };
        }
    }
}