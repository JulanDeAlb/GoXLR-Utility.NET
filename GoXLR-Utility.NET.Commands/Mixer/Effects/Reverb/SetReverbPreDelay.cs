using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbPreDelay : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Reverb Pre Delay of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetReverbPreDelay(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetReverbPreDelay), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbPreDelay"] = value
            };
        }

        /// <summary>
        /// Set the Reverb Pre Delay of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetReverbPreDelay(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbPreDelay), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbPreDelay), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbPreDelay"] = value
            };
        }
    }
}