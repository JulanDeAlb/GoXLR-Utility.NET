using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoDelayRight : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 2500;

        /// <summary>
        /// Set the Echo Delay Right of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 2500)</param>
        public SetEchoDelayRight(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoDelayLeft), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoDelayLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoDelayRight"] = new object[]
                {
                    value
                }
            };
        }
    }
}