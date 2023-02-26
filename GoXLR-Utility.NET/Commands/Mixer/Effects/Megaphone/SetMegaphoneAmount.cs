using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone
{
    public class SetMegaphoneAmount : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Megaphone Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetMegaphoneAmount(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetMegaphoneAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneAmount"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Megaphone Amount of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetMegaphoneAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetMegaphoneAmount), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetMegaphoneAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneAmount"] = new
                {
                    value
                }
            };
        }
    }
}