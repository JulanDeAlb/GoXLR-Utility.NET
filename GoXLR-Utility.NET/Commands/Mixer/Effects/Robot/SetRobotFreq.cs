using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Robot;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    //TODO Value currently like Random Displayed from Utility Side, need to have a look into it more

    public class SetRobotFreq : DeviceCommandBase
    {
        private static readonly int[] MinValues = { 0, 86, 182};
        private static readonly int[] MaxValues = { 88, 184, 240};

        /// <summary>
        /// Set the Robot Frequency of a Range of the current Preset.<br/>
        /// <br/>
        /// Low: 0 - 88<br/>
        /// Medium: 86 - 184<br/>
        /// High: 182 - 240<br/>
        /// </summary>
        /// <param name="range">The Range to edit</param>
        /// <param name="value">Value as Int</param>
        public SetRobotFreq(RobotRange range, int value)
        {
            switch (range)
            {
                case RobotRange.Low:
                    value = value < MinValues[0] ? SetMinValue(nameof(SetRobotFreq), MinValues[0]) : value;
                    value = value > MaxValues[0] ? SetMaxValue(nameof(SetRobotFreq), MaxValues[0]) : value;
                    break;

                case RobotRange.Medium:
                    value = value < MinValues[1] ? SetMinValue(nameof(SetRobotFreq), MinValues[1]) : value;
                    value = value > MaxValues[1] ? SetMaxValue(nameof(SetRobotFreq), MaxValues[1]) : value;
                    break;

                case RobotRange.High:
                    value = value < MinValues[2] ? SetMinValue(nameof(SetRobotFreq), MinValues[2]) : value;
                    value = value > MaxValues[2] ? SetMaxValue(nameof(SetRobotFreq), MaxValues[2]) : value;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(range), range, null);
            }

            Command = new Dictionary<string, object>
            {
                ["SetRobotFreq"] = new object[]
                {
                    range.ToString(),
                    value
                }
            };
        }
    }
}