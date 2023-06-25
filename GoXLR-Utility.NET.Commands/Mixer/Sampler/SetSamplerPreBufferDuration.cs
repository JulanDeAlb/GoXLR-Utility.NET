using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class SetSamplerPreBufferDuration : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 30000;

        /// <summary>
        /// Set the Echo Amount of the Current Preset.
        /// </summary>
        /// <param name="value">The Amount as Int (0 - 100)</param>
        public SetSamplerPreBufferDuration(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetSamplerPreBufferDuration), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetSamplerPreBufferDuration), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetSamplerPreBufferDuration"] = value
            };
        }
    }
}