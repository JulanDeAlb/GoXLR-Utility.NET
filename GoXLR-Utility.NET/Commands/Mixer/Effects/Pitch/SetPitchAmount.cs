using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchAmount : DeviceCommandBase
    {
        private const int MinValue = -24;
        private const int MaxValue = 24;

        /// <summary>
        /// Set the Pitch Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (0 - 100)</param>
        public SetPitchAmount(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetPitchAmount), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetPitchAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetPitchAmount"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Pitch Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetPitchAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetPitchAmount), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetPitchAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetPitchAmount"] = new
                {
                    value
                }
            };
        }
    }
}