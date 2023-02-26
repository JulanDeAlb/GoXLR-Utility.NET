using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotGain : DeviceCommandBase
    {
        private const int MinValue = -12;
        private const int MaxValue = 12;

        /// <summary>
        /// Set the Robot Gain of a Range of the current Preset.
        /// </summary>
        /// <param name="range">The Range to edit</param>
        /// <param name="value">Value as sByte (-12 -12)</param>
        public SetRobotGain(RobotRange range, sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetRobotGain), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetRobotGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotGain"] = new
                {
                    range,
                    value
                }
            };
        }

        /// <summary>
        /// Set the Robot Gain of a Range of the current Preset.
        /// </summary>
        /// <param name="range">The Range to edit</param>
        /// <param name="value">Value as Int (-12 -12)</param>
        public SetRobotGain(RobotRange range, int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotGain), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotGain"] = new
                {
                    range,
                    value
                }
            };
        }
    }
}