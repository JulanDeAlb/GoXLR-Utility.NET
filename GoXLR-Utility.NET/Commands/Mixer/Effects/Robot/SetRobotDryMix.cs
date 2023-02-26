using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotDryMix : DeviceCommandBase
    {
        private const int MinValue = -36;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Robot Dry Mix of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-36 - 0)</param>
        public SetRobotDryMix(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetRobotDryMix), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetRobotDryMix), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotDryMix"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Robot Dry Mix of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-36 - 0)</param>
        public SetRobotDryMix(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotDryMix), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotDryMix), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotDryMix"] = new
                {
                    value
                }
            };
        }
    }
}