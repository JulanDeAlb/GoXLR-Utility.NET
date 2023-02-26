using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneRate : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the HardTune Rate of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetHardTuneRate(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetHardTuneRate), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetHardTuneRate"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the HardTune Rate of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetHardTuneRate(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetHardTuneRate), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetHardTuneRate), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetHardTuneRate"] = new
                {
                    value
                }
            };
        }
    }
}