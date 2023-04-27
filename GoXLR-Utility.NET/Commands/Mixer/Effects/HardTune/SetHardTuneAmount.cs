using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneAmount : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the HardTune Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetHardTuneAmount(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetHardTuneRate), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetHardTuneAmount"] = value
            };
        }

        /// <summary>
        /// Set the HardTune Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetHardTuneAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetHardTuneRate), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetHardTuneRate), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetHardTuneAmount"] = value
            };
        }
    }
}