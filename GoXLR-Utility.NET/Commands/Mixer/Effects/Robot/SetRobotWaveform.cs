using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Robot
{
    public class SetRobotWaveform : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 2;

        /// <summary>
        /// Set the Robot Waveform of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 2)</param>
        public SetRobotWaveform(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetRobotWaveform), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotWaveform"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Robot Waveform of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 2)</param>
        public SetRobotWaveform(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetRobotWaveform), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetRobotWaveform), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetRobotWaveform"] = new
                {
                    value
                }
            };
        }
    }
}