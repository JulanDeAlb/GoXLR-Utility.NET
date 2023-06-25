using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbAmount : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set Reverb Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetReverbAmount(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetReverbAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbAmount"] = value
            };
        }

        /// <summary>
        /// Set Reverb Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetReverbAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbAmount), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbAmount"] = value
            };
        }
    }
}