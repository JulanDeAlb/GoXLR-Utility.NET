using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoDelayLeft : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 2500;

        /// <summary>
        /// Set the Echo Delay Left of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 2500)</param>
        public SetEchoDelayLeft(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoDelayLeft), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoDelayLeft), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoDelayLeft"] = value
            };
        }
    }
}