using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Gender
{
    public class SetGenderAmount : DeviceCommandBase
    {
        private const int MinValue = -12;
        private const int MaxValue = 12;

        /// <summary>
        /// Set the Gender Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-12 - 12)</param>
        public SetGenderAmount(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetGenderAmount), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetGenderAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGenderAmount"] = value
            };
        }

        /// <summary>
        /// Set the Gender Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-12 - 12)</param>
        public SetGenderAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetGenderAmount), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetGenderAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGenderAmount"] = value
            };
        }
    }
}