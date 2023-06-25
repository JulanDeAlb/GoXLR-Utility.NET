using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateThreshold : DeviceCommandBase
    {
        private const int MinValue = -59;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Gate Threshold.
        /// </summary>
        /// <param name="value">The value as sByte (-59 - 0)</param>
        public SetGateThreshold(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetGateThreshold), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetGateThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGateThreshold"] = value
            };
        }

        /// <summary>
        /// Set the Gate Threshold.
        /// </summary>
        /// <param name="value">The value as Int (-59 - 0)</param>
        public SetGateThreshold(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetGateThreshold), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetGateThreshold), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGateThreshold"] = value
            };
        }
    }
}