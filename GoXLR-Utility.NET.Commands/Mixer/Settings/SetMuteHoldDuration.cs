using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Settings
{
    public class SetMuteHoldDuration : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 5000;

        /// <summary>
        /// Set the Mute Hold Duration.
        /// </summary>
        /// <param name="value">Value as Int (0 - 5000)</param>
        public SetMuteHoldDuration(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetMuteHoldDuration), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetMuteHoldDuration), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetMuteHoldDuration"] = value
            };
        }
    }
}